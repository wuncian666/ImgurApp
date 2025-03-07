using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace ImgurApp.Components.PaginationComponent
{
    public partial class Pagination : UserControl
    {
        private int itemsPerPage = 10; // 一頁幾筆
        private int totalItems = 378;
        private int totalPages;
        private int baseVisiblePages = 10;
        private int currentPagination = 1;
        private int currentPage = 0;

        public Pagination()
        {
            InitializeComponent();

            // ex : 379 / 10 = 37 ... 9
            // ex : 4 / 10 = 0 ... 4
            this.totalPages = this.totalItems % this.itemsPerPage == 0
                ? this.totalItems / this.itemsPerPage
                : this.totalItems / this.itemsPerPage + 1;
            Console.WriteLine($"Total Pages: {this.totalPages}");
            this.CreatePagination();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            int currentVisiblePages = this.CalculateCurrentVisiblePages(this.currentPagination);
            Console.WriteLine($"Before: Pagination={currentPagination}, Page={currentPage}");
            if (this.currentPage < currentVisiblePages - 1)
            {
                this.currentPage++;
            }
            else if (this.HasNextButton())
            {
                this.currentPagination++;
                this.currentPage = 0;
            }
            Console.WriteLine($"After: Pagination={currentPagination}, Page={currentPage}");
            this.CreatePagination();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Before: Pagination={currentPagination}, Page={currentPage}");
            if (this.currentPage > 0)
            {
                this.currentPage--;
            }
            else if (this.HasPreviousButton())
            {
                this.currentPagination--;
                this.currentPage = this.CalculateCurrentVisiblePages(this.currentPagination) - 1;
            }
            Console.WriteLine($"After: Pagination={currentPagination}, Page={currentPage}");
            this.CreatePagination();
        }

        private bool HasPreviousButton()
        {
            return this.currentPagination > 1 || this.currentPage > 0;
        }

        private bool HasNextButton()
        {
            int currentAbsolutePage = (this.currentPagination - 1) * this.baseVisiblePages + this.currentPage + 1;

            return currentAbsolutePage < this.totalPages;
        }

        private void CreatePagination()
        {
            paginationPanel.Controls.Clear();

            if (this.HasPreviousButton())
            {
                this.AddPreviousButton();
            }
            int currentVisiblePages = this.CalculateCurrentVisiblePages(this.currentPagination);
            Console.WriteLine($"Current Visible Pages: {currentVisiblePages}");
            int startPage = (this.currentPagination - 1) * this.baseVisiblePages + 1;
            Console.WriteLine($"Start Page: {startPage}");
            for (int i = 0; i < currentVisiblePages; i++)
            {
                int pageNumber = startPage + i;
                this.AddCurrentPageButton(pageNumber, i);
            }

            if (this.HasNextButton())
            {
                this.AddNextButton();
            }
        }

        private void AddPreviousButton()
        {
            Button backBtn = new Button
            {
                Text = "<",
                Width = 45,
                Height = 45
            };

            backBtn.Click += PreviousBtn_Click;

            if (this.currentPagination == 1 && this.currentPage == 0)
            {
                backBtn.Enabled = false;
                backBtn.BackColor = Color.Gray;
                backBtn.ForeColor = Color.Black;
            }
            else
            {
                backBtn.Enabled = true;
                backBtn.BackColor = Color.Empty;
                backBtn.BackColor = Color.Empty;
            }
            paginationPanel.Controls.Add(backBtn);
        }

        private void AddCurrentPageButton(int pageNumber, int index)
        {
            Button currentPageBtn = new Button
            {
                Text = pageNumber.ToString(),
                Width = 45,
                Height = 45
            };

            if (index == this.currentPage)
            {
                currentPageBtn.BackColor = Color.Blue;
                currentPageBtn.ForeColor = Color.White;
            }

            currentPageBtn.Click += (s, e) =>
            {
                this.currentPage = index;
                this.CreatePagination();
            };
            paginationPanel.Controls.Add(currentPageBtn);
        }

        private void AddNextButton()
        {
            Button nextBtn = new Button
            {
                Text = ">",
                Width = 45,
                Height = 45
            };
            nextBtn.Click += NextBtn_Click;
            int currentAbsolutePage = (this.currentPagination - 1) * this.baseVisiblePages + this.currentPage + 1;

            if (currentAbsolutePage == this.totalPages) // 最後一頁
            {
                nextBtn.Enabled = false;
                nextBtn.BackColor = Color.Gray;
                nextBtn.ForeColor = Color.Black;
            }
            else
            {
                nextBtn.Enabled = true;
                nextBtn.BackColor = Color.Empty;
                nextBtn.BackColor = Color.Empty;
            }
            paginationPanel.Controls.Add(nextBtn);
        }

        private int CalculateCurrentVisiblePages(int currentPagination)
        {
            int totalPaginations = (this.totalPages - 1) / this.baseVisiblePages + 1;
            Console.WriteLine($"Total Paginations: {totalPaginations}, Total Pages: {this.totalPages}");
            if (currentPagination == totalPaginations)
            {
                // 最後一個pagination的頁數
                int remainingPages = totalPages - (currentPagination - 1) * this.baseVisiblePages;
                return remainingPages;
            }
            return this.baseVisiblePages;
        }
    }
}
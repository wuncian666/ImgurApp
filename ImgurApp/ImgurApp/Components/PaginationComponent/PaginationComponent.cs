﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static ImgurApp.Components.PaginationComponent.PaginationContract;

namespace ImgurApp.Components.PaginationComponent
{
    public partial class PaginationComponent : UserControl, IPaginationView
    {
        private Button previous = null;
        private readonly PaginationPresenter presenter;

        public event EventHandler<int> PageNumberChange;

        // 只有一開始發 api 時會拿到 total item 的值
        public int TotalItems
        {
            set
            {
                presenter.TotalItems = value;
                presenter.InitialPages();
            }
        }

        public int ItemPrePages
        {
            get
            {
                return presenter.ItemsPerPage;
            }
            set
            {
                presenter.ItemsPerPage = value;
            }
        }

        public PaginationComponent()
        {
            InitializeComponent();
            presenter = new PaginationPresenter(this);
        }

        public void RenderPagationList(List<int> pages)
        {
            paginationPanel.Controls.Clear();

            this.AddPrevious5PageButton();

            this.AddPreviousButton();

            for (int i = 0; i < pages.Count; i++)
            {
                this.AddPageButton(pages[i]);
            }

            this.AddNextButton();

            this.AddNext5PageButon();

            this.ActivePageIndex(this.presenter.CurrentPage);
        }

        private void ChangePage_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Direction direction = (Direction)button.Tag;
            this.presenter.ChangePage(direction);
        }

        public void ActivePageIndex(int page)
        {
            ResetPageButton();

            foreach (Control control in paginationPanel.Controls)
            {
                if (control is Button btn)
                {
                    if (btn.Text == page.ToString())
                    {
                        btn.BackColor = Color.Blue;
                        btn.ForeColor = Color.White;
                        previous = btn;
                    }
                }
            }

            this.EnabledPreviousNextButton();

            PageNumberChange?.Invoke(this, page);
        }

        private void EnabledPreviousNextButton()
        {
            if (paginationPanel.Controls.Count == 0)
            {
                return;
            }

            Button previousBtn =
                paginationPanel.Controls.OfType<Button>()
                .First(x => x.Tag != null && x.Tag.Equals(Direction.Previous));
            previousBtn.Enabled = !(presenter.CurrentPage == 1);

            Button nextBtn =
                paginationPanel.Controls.OfType<Button>()
                .First(x => x.Tag != null && x.Tag.Equals(Direction.Next));
            nextBtn.Enabled = !(presenter.CurrentPage == presenter.MaxPage);
        }

        private void ResetPageButton()
        {
            if (previous != null)
            {
                previous.BackColor = Color.Empty;
                previous.ForeColor = Color.Black;
            }
        }

        private void AddPageButton(int page)
        {
            Button button = new Button
            {
                Height = 35,
                Width = 35,
                Text = page.ToString()
            };
            button.Click += Page_Click;
            paginationPanel.Controls.Add(button);
        }

        private void Page_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.presenter.CurrentPage = int.Parse(button.Text);
        }

        private void AddPreviousButton()
        {
            Button button = new Button
            {
                Height = 35,
                Width = 35,
                Text = "<",
                Tag = Direction.Previous
            };
            button.Click += ChangePage_Click;
            paginationPanel.Controls.Add(button);
        }

        private void AddNextButton()
        {
            Button button = new Button
            {
                Height = 35,
                Width = 35,
                Text = ">",
                Tag = Direction.Next
            };
            button.Click += ChangePage_Click;
            paginationPanel.Controls.Add(button);
        }

        private void AddNext5PageButon()
        {
            Button button = new Button
            {
                Height = 35,
                Width = 35,
                Text = ">>",
                Tag = Direction.Next5
            };
            button.Click += ChangePage_Click;
            paginationPanel.Controls.Add(button);
        }

        private void AddPrevious5PageButton()
        {
            Button button = new Button
            {
                Height = 35,
                Width = 35,
                Text = "<<",
                Tag = Direction.Previous5
            };
            button.Click += ChangePage_Click;
            paginationPanel.Controls.Add(button);
        }
    }
}
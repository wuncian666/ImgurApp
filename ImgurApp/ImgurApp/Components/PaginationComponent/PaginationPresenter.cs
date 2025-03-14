using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ImgurApp.Components.PaginationComponent.PaginationContract;

namespace ImgurApp.Components.PaginationComponent
{
    internal class PaginationPresenter : IPaginationPresenter
    {
        private int _totalItems = 0;

        public int TotalItems
        {
            get
            {
                return _totalItems;
            }
            set
            {
                _totalItems = value;
                Console.WriteLine($"total items = {_totalItems}");
                MaxPage =
                    _totalItems % ItemsPerPage == 0 ?
                    _totalItems / ItemsPerPage :
                    (_totalItems / ItemsPerPage) + 1;
                CurrentPage = 1;
            }
        }

        public int ItemsPerPage { get; set; }

        // 一個pagination 幾個page
        public int PagesCount { get; set; } = 10;

        public int MaxPage { get; set; }

        private int _currentPage = 1;

        public int CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                if (value <= 0)
                {
                    _currentPage = 1;
                }
                else if (value > MaxPage)
                {
                    _currentPage = MaxPage;
                }
                else
                {
                    _currentPage = value;
                    this._view.ActivePageIndex(_currentPage);
                }
            }
        }

        private readonly IPaginationView _view;

        public PaginationPresenter(IPaginationView view)
        {
            this._view = view;
        }

        public void ChangePage(Direction direction)
        {
            switch (direction)
            {
                case Direction.Next:
                    this.NextPage();
                    break;

                case Direction.Previous:
                    this.PreviousPage();
                    break;

                case Direction.Next5:
                    this.Next5Page();
                    break;

                case Direction.Previous5:
                    this.Previous5Page();
                    break;
            }
        }

        public void InitialPages()
        {
            int pagesCount = (PagesCount < MaxPage) ?
                PagesCount : MaxPage % PagesCount;
            var pages = CreatePageNumbers(1, pagesCount);
            this._view.RenderPagationList(pages);
        }

        private List<int> CreatePageNumbers(int start, int end)
        {
            List<int> pages = new List<int>();
            for (int i = start; i <= end; i++)
            {
                pages.Add(i);
            }
            return pages;
        }

        private void NextPage()
        {
            if (CurrentPage == MaxPage)
            {
                return;
            }

            CurrentPage++;
            if (CurrentPage % PagesCount == 1)
            {
                int start = CurrentPage;
                int end = Math.Min(start + PagesCount - 1, MaxPage);
                var pages = CreatePageNumbers(start, end);

                this._view.RenderPagationList(pages);
            }
            else
            {
                this._view.ActivePageIndex(CurrentPage);
            }
        }

        private void Next5Page()
        {
            if (CurrentPage + 5 > MaxPage)
            {
                return;
            }

            //25 / 10 + 1 3
            int oldStartPage = ((CurrentPage - 1) / PagesCount) * PagesCount + 1;
            CurrentPage += 5;
            //30 / 10 + 1 4
            int newStartPage = ((CurrentPage - 1) / PagesCount) * PagesCount + 1;
            if (oldStartPage != newStartPage)
            {
                int end = Math.Min(newStartPage + PagesCount - 1, MaxPage);
                var pages = CreatePageNumbers(newStartPage, end);

                this._view.RenderPagationList(pages);
            }
            else
            {
                this._view.ActivePageIndex(CurrentPage);
            }
        }

        private void PreviousPage()
        {
            if (CurrentPage == 1)
            {
                return;
            }
            CurrentPage--;
            if (CurrentPage % PagesCount == 0)
            {
                int start = CurrentPage - PagesCount + 1;
                int end = CurrentPage;
                var pages = CreatePageNumbers(start, end);

                this._view.RenderPagationList(pages);
            } else
            {
                this._view.ActivePageIndex(CurrentPage);
            }
        }

        private void Previous5Page()
        {
            if (CurrentPage - 5 < 1)
            {
                return;
            }
            // 11 , 10/10 + 1
            int oldStartPage = ((CurrentPage - 1) / PagesCount) * PagesCount + 1;
            // 8/10 + 1 = 1
            CurrentPage -= 5;
            int newStartPage = ((CurrentPage - 1) / PagesCount) * PagesCount + 1;
            if (oldStartPage != newStartPage)
            {
                int end = Math.Min(newStartPage + PagesCount - 1, MaxPage);
                var pages = CreatePageNumbers(newStartPage, end);

                this._view.RenderPagationList(pages);
            }
            else
            {
                this._view.ActivePageIndex(CurrentPage);
            }
        }
    }
}
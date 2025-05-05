using System.Collections.Generic;

namespace ImgurApp.Components.PaginationComponent
{
    internal class PaginationContract
    {
        public interface IPaginationView
        {
            /// <summary>
            /// 前端統一收到 pages 的頁碼後，直接進行畫面渲染（按鈕的產生）
            /// </summary>
            /// <param name="pages"></param>
            void RenderPagationList(List<int> pages);

            /// <summary>
            /// 前端根據 page 參數將畫面指定的按鈕進行 Active
            /// </summary>
            /// <param name="page">要 Active 的按鈕</param>
            void ActivePageIndex(int page);
        }

        public interface IPaginationPresenter
        {
            /// <summary>
            /// 初始化分頁頁碼給前端
            /// </summary>
            void InitialPages();

            /// <summary>
            /// 根據方向決定 current page 的增減（考慮換頁情形）
            /// </summary>
            /// <param name="direction">如果為 next currentpage + 1，如果為 previous currentpage - 1</param>
            void ChangePage(Direction direction);
        }
    }
}
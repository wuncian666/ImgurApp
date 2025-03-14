﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Components.PaginationComponent
{
    internal class PaginationContract
    {
        public interface IPaginationView
        {
            /// <summary>
            /// 前端統一收到pages的頁碼後直接進行畫面渲染(按鈕的產生)
            /// </summary>
            /// <param name="pages"></param>
            void RenderPagationList(List<int> pages);

            /// <summary>
            /// 前端根據page參數將畫面指定的按鈕進行 Active
            /// </summary>
            /// <param name="page">要Active的按鈕</param>
            void ActivePageIndex(int page);
        }

        public interface IPaginationPresenter
        {
            /// <summary>
            /// 初始化分頁頁碼給前端
            /// </summary>
            void InitialPages();

            /// <summary>
            /// 根據方向決定 current page 的增減(考慮換頁情形)
            /// </summary>
            /// <param name="direction">如果為next currentpage +1，如果為previous currentpage -1</param>
            void ChangePage(Direction direction);
        }
    }
}
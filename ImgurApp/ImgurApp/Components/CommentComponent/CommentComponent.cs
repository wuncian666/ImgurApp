using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImgurApp.Contracts;
using ImgurAPI.Models;
using ImgurApp.Presenters;

namespace ImgurApp.Components.CommentComponent
{
    public partial class CommentComponent :
        UserControl
    {
        public CommentComponent(CommentsModel.Datum comment)
        {
            InitializeComponent();
            this.UserLabel.Text = comment.author;
            this.commentLabel.Text = comment.comment;
        }
    }
}
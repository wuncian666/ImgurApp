using ImgurAPI.Models;
using ImgurApp.Components.ImageItemComponent;
using ImgurApp.Contracts;
using ImgurApp.Models;
using ImgurApp.Presenters;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ImgurApp.Forms
{
    public partial class AlbumsForm : Form, IAlbumsView
    {
        private readonly IAlbumsPresenter _presenter;

        public AlbumsForm()
        {
            InitializeComponent();

            this._presenter = new AlbumsPresenter(this);
            this._presenter.GetAlbumsAsync();
        }

        public void AlbumsLoaded(AlbumsModel.Datum[] response)
        {
            this._presenter.GetAlbumWithVoteAsync(response);
        }

        public void AlbumsWithVoteLoaded(List<AlbumsModelWithVote> response)
        {
            for (int i = 0; i < response.Count(); i++)
            {
                var album = new AlbumItemComponent(response[i]);
                this.albumContainer.Controls.Add(album);
            }
        }
    }
}
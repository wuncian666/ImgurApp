using AutoMapper;
using ImgurAPI;
using ImgurAPI.Models;
using ImgurApp.Contracts;
using ImgurApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class AccountImagesPresenter : IAlbumsPresenter
    {
        private readonly IAlbumsView _view;

        public AccountImagesPresenter(IAlbumsView view)
        {
            _view = view;
        }

        public async Task GetAlbumsAsync()
        {
            ImgurContext context = new ImgurContext();
            var response = await context.Account.GetAlbums(
                AccountModel.Account_url, "0");
            if (!response.success)
            {
                throw new Exception("Failed to load account images");
            }

            List<AlbumsModelWithVote> results = new List<AlbumsModelWithVote>();

            for (int i = 0; i < response.data.Count(); i++)
            {
                AlbumImageVotesModel voteResponse =
                    await context.Album.AlbumImageVotes(response.data[i].id);

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<AlbumsModel.Datum, AlbumsModelWithVote>()
                    .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.id))
                    .ForMember(dest => dest.link, opt => opt.MapFrom(src => src.link))
                    .ForMember(dest => dest.cover, opt => opt.MapFrom(src => src.cover))
                    .ForMember(dest => dest.title, opt => opt.MapFrom(src => src.title))
                    .ForMember(dest => dest.description, opt => opt.MapFrom(src => src.description))
                    .ForMember(dest => dest.accountUrl, opt => opt.MapFrom(src => src.account_url))
                    .ForMember(dest => dest.accountId, opt => opt.MapFrom(src => src.account_id))
                    .ForMember(dest => dest.views, opt => opt.MapFrom(src => src.views));
                    cfg.CreateMap<AlbumImageVotesModel.Data, AlbumsModelWithVote>()
                    .ForMember(dest => dest.ups, opt => opt.MapFrom(src => src.ups))
                    .ForMember(dest => dest.downs, opt => opt.MapFrom(src => src.downs));
                });

                var mapper = config.CreateMapper();

                var albumWithVote = mapper.Map<AlbumsModelWithVote>(response.data[i]);
                if (voteResponse == null || voteResponse.data == null)
                {
                    albumWithVote.ups = 0;
                    albumWithVote.downs = 0;
                }
                else
                {
                    mapper.Map(voteResponse.data, albumWithVote);
                }

                results.Add(albumWithVote);
            }

            _view.AlbumsLoaded(results);
        }
    }
}
using AutoMapper;
using ImgurAPI;
using ImgurAPI.Models;
using ImgurApp.Contracts;
using ImgurApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImgurApp.Presenters
{
    internal class AlbumsPresenter : IAlbumsPresenter
    {
        private readonly IAlbumsView _view;
        private readonly ImgurContext _context;

        public AlbumsPresenter(IAlbumsView view)
        {
            _view = view;
            _context = new ImgurContext();
        }

        public async Task GetAlbumsAsync()
        {
            var response = await _context.Account.GetAlbums(
                AccountModel.Account_url, "0");
            if (!response.success)
            {
                throw new Exception("Failed to load account images");
            }

            this._view.AlbumsLoaded(response.data);
        }

        public async Task GetAlbumWithVoteAsync(AlbumsModel.Datum[] response)
        {
            List<AlbumsModelWithVote> results = new List<AlbumsModelWithVote>();

            for (int i = 0; i < response.Count(); i++)
            {
                AlbumImageVotesModel voteResponse =
                    await _context.Gallery.AlbumImageVotes(response[i].id);

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

                var albumWithVote = mapper.Map<AlbumsModelWithVote>(response[i]);
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

            _view.AlbumsWithVoteLoaded(results);
        }
    }
}
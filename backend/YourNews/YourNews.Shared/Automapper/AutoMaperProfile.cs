using System;
using System.Linq;
using AutoMapper;
using YourNews.DAL.Entities;
using YourNews.Shared.DTO;
using YourNews.DAL.Abstractions;
using System.Collections.Generic;

namespace AdvertisementsService.API.BLL.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<News, NewsDTO>().IncludeBase<MainEntity,MainEntityDTO>();

            CreateMap<NewsDTO, News>().IncludeBase<MainEntityDTO, MainEntity>();

            CreateMap<NewsToUser, NewsToUserDTO>().IncludeBase<MainEntity, MainEntityDTO>();

            CreateMap<NewsToUserDTO, NewsToUser>().IncludeBase<MainEntityDTO, MainEntity>();

            CreateMap<Paper, PaperDTO>().IncludeBase<MainEntity, MainEntityDTO>();

            CreateMap<PaperDTO, Paper>().IncludeBase<MainEntityDTO, MainEntity>();

            CreateMap<Publisher, PublisherDTO>().IncludeBase<MainEntity, MainEntityDTO>();

            CreateMap<PublisherDTO, Publisher>().IncludeBase<MainEntityDTO, MainEntity>();

            CreateMap<User, UserDTO>().IncludeBase<MainEntity, MainEntityDTO>();

            CreateMap<UserDTO, User>().IncludeBase<MainEntityDTO, MainEntity>();
        }
    }
}
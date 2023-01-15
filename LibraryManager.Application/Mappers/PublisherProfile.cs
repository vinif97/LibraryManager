using AutoMapper;
using LibraryManager.Application.DTOs;
using LibraryManager.Domain.Models;

namespace LibraryManager.Application.Mappers
{
    public class PublisherProfile : Profile
    {
        public PublisherProfile()
        {
            CreateMap<Publisher, PublisherUpdateGetDTO>().ReverseMap();
            CreateMap<Publisher, PublisherAddDTO>().ReverseMap();
        }
    }
}

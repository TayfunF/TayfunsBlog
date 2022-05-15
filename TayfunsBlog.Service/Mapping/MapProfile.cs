using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TayfunsBlog.Core.Dtos;
using TayfunsBlog.Core.Models;

namespace TayfunsBlog.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AboutDto, About>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CommentDto, Comment>().ReverseMap();
            CreateMap<PostDto, Post>().ReverseMap();
            CreateMap<WriterDto, Writer>().ReverseMap();
        }
    }
}

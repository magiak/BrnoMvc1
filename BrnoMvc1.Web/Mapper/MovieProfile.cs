using AutoMapper;
using BrnoMvc1.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrnoMvc1.Web.Mapper
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            this.CreateMap<Movie, MovieViewModel>()
                .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title + "* (18+)"));
        }
    }
}
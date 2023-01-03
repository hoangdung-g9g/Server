using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using hoangdung.Server.BLL.Models;
using hoangdung.Server.DAL.Entity;

namespace hoangdung.Server.API
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ToDoModel,ToDo>();
        }
    }
}
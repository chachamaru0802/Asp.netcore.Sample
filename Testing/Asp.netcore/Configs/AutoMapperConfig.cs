using Asp.netcore.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netcore.Configs
{
    public static class AutoMapperConfig
    {
        public static void init()
        { 
            Mapper.Initialize(c =>
            {
                c.CreateMap<Sample, User>();
            });

        }
    }
}

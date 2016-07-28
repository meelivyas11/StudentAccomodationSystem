using AutoMapper;
using StudentAccommodationSystem.Models;
using StudentAccommodationSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAccommodationSystem
{
    public class SASMapperConfig
    {
        public static void Setup()
        {
            Mapper.Initialize(cfg =>
           {
               cfg.CreateMap<LoginViewModel, UserModel>();

               cfg.CreateMap<RegisterViewModel, UserModel>();
           });
        }
    }
}
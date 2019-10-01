﻿using Restaurantes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantes.Profile
{
    public class MapProfile : AutoMapper.Profile
    {
       public MapProfile()
        {
            CreateMap<Restaurante.Core.Entities.Restaurante, RestauranteViewModel>().ReverseMap();
        }
    }
}

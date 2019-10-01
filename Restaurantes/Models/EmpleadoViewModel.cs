﻿using Restaurantes.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantes.Models
{
    public class EmpleadoViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int RestauranteId { get; set; }
        public int Puesto { get; set; }

        public Restaurante Restaurante { get; set; }
       
     
    }
}
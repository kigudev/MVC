﻿using Restaurantes.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurantes.Infrastructure.Data
{
    public class AppDbContextSeed
    {
        public static void Seed(AppDbContext catalogContext)
        {
            if (!catalogContext.Restaurantes.Any())
            {
                catalogContext.Add(new Restaurante
                {
                    Nombre = "Restaurante Maestro",
                    Domicilio = "Ave. Prueba 123",
                    Telefono = 686156,
                    HoraDeCierre = 10
                });


                catalogContext.SaveChanges();
            }
        }
    }
}

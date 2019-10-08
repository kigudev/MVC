﻿using System;
using System.Collections.Generic;

namespace Restaurantes.Core.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int RestauranteId { get; set; }
        public ICollection<OrdenTieneProducto> Ordenes { get; set; }
        public Restaurante Restaurante { get; set; }
    }
}

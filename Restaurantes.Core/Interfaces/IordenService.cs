﻿using Restaurantes.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurantes.Core.Interfaces
{
    public interface IOrdenService
    {
        List<Orden> ObtenerTodo();
    }
}

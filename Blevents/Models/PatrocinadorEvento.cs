﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blevents.Models
{
    public class PatrocinadorEvento
    {

        public int PatrocinadorEventoId { get; set; }
        public decimal ValorPatrocinado { get; set; }

        public int? EventoId { get; set; }
        public Evento EventoVirtual { get; set; }

        public int? PatrocinadorId { get; set; }
        public Patrocinador PatrocinadorVirtual { get; set; }
    }
}

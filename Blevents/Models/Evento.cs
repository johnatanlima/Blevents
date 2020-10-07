﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blevents.Models
{
    public class Evento
    {
        public Evento()
        {
            PatrociniosValor = new HashSet<PatrocinadorEvento>();
        }

        public int EventoId { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }
        
        public string BannerUrl { get; set; }
       
        public string Gratuito_Pago { get; set; } //Alteradao valor booleano. 
        
        public DateTime DataInicio { get; set; } //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        
        public DateTime DataFinal { get; set; }

        //Relacionamento EVENTO-REALIZADOR
        public int? RealizadorId { get; set; }
        public Realizador RealizadorVirtual { get; set; }

        //Relacionamento 
        public ICollection<PatrocinadorEvento> PatrociniosValor { get; set; }
    }
}

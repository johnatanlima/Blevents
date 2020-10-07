using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blevents.Models
{
    public class Realizador
    {
        public Realizador()
        {
            Eventos = new HashSet<Evento>();
        }

        public int RealizadorId { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public ICollection<Evento> Eventos { get; set; }
    }
}

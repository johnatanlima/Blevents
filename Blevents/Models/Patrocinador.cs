using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blevents.Models
{
    public class Patrocinador
    {
        public Patrocinador()
        {
            PatrociniosValor = new HashSet<PatrocinadorEvento>();
        }

        public int PatrocinadorId { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public ICollection<PatrocinadorEvento> PatrociniosValor { get; set; }

    }
}

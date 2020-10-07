using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blevents.Models
{
    public class NivelAcesso : IdentityRole<string>
    {
        [Display(Description = "Definição Nível Acesso")]
        public string DescricaoNivelAcesso { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonsterHelper.Models
{
    public class Serie
    {
        public long SerieID { get; set; }

        [Required(ErrorMessage = "Informe o número de repetições")]
        public int Repeticoes { get; set; }

        [Required(ErrorMessage = "Informe uma carga")]
        public double Carga { get; set; }

        [Required(ErrorMessage="Informe um intervalo de descanso")]
        public int Intervalo { get; set; }
    }
}
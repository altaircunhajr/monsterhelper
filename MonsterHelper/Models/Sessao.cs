using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonsterHelper.Models
{
    public class Sessao
    {
        public Sessao()
        {
            Series = new List<Serie>();
        }

        public long SessaoID { get; set; }
        public long ExercicioID { get; set; }

        [Required(ErrorMessage = "Selecione ao menos um exercício")]
        public virtual Exercicio Exercicio { get; set; }
        public virtual ICollection<Serie> Series { get; set; }

    }
}
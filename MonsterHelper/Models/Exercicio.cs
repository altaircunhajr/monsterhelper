using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonsterHelper.Models
{
    public class Exercicio
    {
        public Exercicio()
        {
            AtuacoesMusculares = new List<AtuacaoMuscular>();
        }
        public long ExercicioID { get; set; }

        [Required(ErrorMessage="Informe um nome para o exercício")]
        [StringLength(50, ErrorMessage="Valor muito grande para o campo")]
        public string Nome { get; set; }
        public virtual ICollection<AtuacaoMuscular> AtuacoesMusculares { get; set; }
    }
}
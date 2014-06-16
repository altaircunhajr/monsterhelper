using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonsterHelper.Models
{
    public class AtuacaoMuscular
    {
        public enum TiposdeAutuacao { Agonista, Antagonista, Sinergista }
        public AtuacaoMuscular()
        {
            Musculos = new List<Musculo>();
        }
        public long AtuacaoMuscularID { get; set; }

        public virtual ICollection<Musculo> Musculos { get; set; }

        [Required]
        public TiposdeAutuacao TipoDeAtuacao { get; set; }
    }
}
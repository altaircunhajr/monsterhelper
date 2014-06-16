using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonsterHelper.Models
{
    public class Treino
    {
        public Treino()
        {
            Sessoes = new List<Sessao>();
            DiasDaSemana = new List<DiaDaSemana>();
        }
        public long TreinoID { get; set; }
        
        [Required(ErrorMessage="O nome do treino é obrigatório")]
        [StringLength(50, ErrorMessage = "Valor muito grande para o campo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Selecione ao menos um dia para este treino")]
        [Display(Name="Agenda do treino")]
        public virtual ICollection<DiaDaSemana> DiasDaSemana { get; set; }
        public virtual ICollection<Sessao> Sessoes { get; set; }
    }

    public class DiaDaSemana
    {
        public int DiaDaSemanaID { get; set; }
        public string Nome { get; set; }
    }

    public class TreinoViewModel
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public TreinoViewModel()
        {
            Semana = new SelectList(db.DiasDaSemana.ToList(), "DiaDaSemanaID", "Nome");
            Treino = new Treino();
        }
        public Treino Treino { get; set; }
        
        public SelectList Semana { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonsterHelper.Models
{
    public class Musculo
    {
        public long MusculoID { get; set; }

        [Required(ErrorMessage="Informe um nome para o músculo")]
        [StringLength(50, ErrorMessage = "Valor muito grande para o campo")]
        public string Nome { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCB_Administrativo.Models
{
    public class Obreiro
    {
        #region KEYS
        [Required]
        public int ID { get; set; }

        public ICollection<CongregacaoObreiro> Congregacoes { get; set; }
        #endregion

        #region VARIABLES
        [StringLength(120, MinimumLength = 6, ErrorMessage = "Nome deve ter entre 6 e 120 caracteres")]
        [Required(ErrorMessage = "Nome deve ser informado")]
        public string Nome { get; set; }

        public bool Status { get; set; }
        #endregion
    }
}

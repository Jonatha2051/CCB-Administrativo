using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CCB_Administrativo.Models
{
    public class Congregacao
    {
        #region KEYS
        //Primary Key:
        [Required]
        public int ID { get; set; }

        //Foreign Keys:
        [ForeignKey("CidadeID")]
        public int CidadeID { get; set; }
        public Cidade Cidade { get; set; }

        public ICollection<CongregacaoObreiro> Obreiros { get; set; }
        #endregion

        #region VARIABLES
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Descrição deve ter mais que 5 caracteres, mas menor de 50!")]
        [Required(ErrorMessage = "A Descrição deve ser preenchida!")]
        public string Descricao { get; set; }

        //Endereço:
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        
        #endregion
    }
}

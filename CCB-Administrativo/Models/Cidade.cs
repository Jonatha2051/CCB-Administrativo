using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCB_Administrativo.Models
{
    public class Cidade
    {
        #region KEYS
        //Primary Key:
        [Key]
        public int ID { get; set; }

        //Foreign Keys:
        #endregion

        #region VARIÁVEIS
        [StringLength(120, ErrorMessage = "Nome da Cidade não pode ter mais de 120 caracteres")]
        [Required(ErrorMessage = "Nome deve ser preenchido")]
        public string Nome { get; set; }

        [StringLength(30, ErrorMessage = "Estado da Cidade não pode ter mais de 30 caracteres")]
        //[Required(ErrorMessage = "Estado deve ser preenchido")]
        public string Estado { get; set; }

        [StringLength(2, ErrorMessage = "Nome da Cidade não pode ter mais de 2 caracteres")]
        [Required(ErrorMessage = "Sigla deve ser preenchida")]
        public string UF { get; set; }
        #endregion
    }
}

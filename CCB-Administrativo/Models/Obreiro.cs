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


        #endregion

        #region VARIABLES
        public string NomeCompleto { get; set; }

        #endregion
    }
}

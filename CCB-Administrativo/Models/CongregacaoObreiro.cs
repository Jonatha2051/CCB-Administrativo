using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CCB_Administrativo.Models
{
    public class CongregacaoObreiro
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("CongregacaoID")]
        public int CongregacaoID { get; set; }
        public Congregacao Congregacao { get; set; }

        [ForeignKey("ObreiroID")]
        public int ObreiroID { get; set; }
        public Obreiro Obreiro { get; set; }
    }
}

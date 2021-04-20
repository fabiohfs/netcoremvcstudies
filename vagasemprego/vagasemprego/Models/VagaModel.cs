using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vagasemprego.Models
{
    public class VagaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VagaID { get; set; }

        public string Titulo { get; set; }

        public string Requisitos { get; set; }

        public string Local { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salario { get; set; }
    }
}

using CentralniUcet.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CentralniUcet.Models
{
    public class Autentifikace
    {
        [Required]
        [Column(TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Veta { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Uzivatel { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime PlatnostDo { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime DatumAktualizace { get; set; }

    }
}

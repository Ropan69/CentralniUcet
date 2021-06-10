using CentralniUcet.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace CentralniUcet.Models
{
    public class OverovaciMail
    {
        [Required]
        [Column(TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Veta { get; set; }

        [Required]
        [Column(TypeName = "bigint")]
        public Int64 IDOverovacihoMailu { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public ETypEmailu TypMailu { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int IDUcetCentralni { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime PlatnostDo { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime DatumAktualizace { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string UzivatelAktualizace { get; set; }

        public UcetCentralni UcetCentralni { get; set; }
    }
}

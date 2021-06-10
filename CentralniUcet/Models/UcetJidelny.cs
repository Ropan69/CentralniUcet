using CentralniUcet.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CentralniUcet.Models
{
    public class UcetJidelny
    {
        [Required]
        [Column(TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Veta { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int IDUcetCentralni { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int IDJidelny { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string IDUcetJidelny { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string PopisUctuJidelny { get; set; }

        [Column(TypeName = "bit")]
        public bool VynutitOvereniHesla { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime DatumAktualizace { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string UzivatelAktualizace { get; set; }

        public UcetCentralni UcetCentralni { get; set; }

    }
}

using CentralniUcet.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CentralniUcet.Models
{
    public class UcetCentralni
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
        public EStavUctu StavUctu { get;set;}

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string Heslo { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string Prijmeni { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string Jmeno { get; set; }

        [Required]
        [Column(TypeName = "varchar(2)")]
        public string Stat { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime SouhlasGDPR { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int VychoziIDJidelny { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string VychoziIDUctuJidelny { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public EPohlavi Pohlavi { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Vek { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string Mesto { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string NastaveniApl { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime DatumAktualizace { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string UzivatelAktualizace { get; set; }


        public List<UcetJidelny> UcetJidelnyList { get; set; }

        public List<OverovaciMail> OverovaciMailList { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistem.Data.Models
{
    [Table("Oda")]
    public class Oda
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10,ErrorMessage ="10 karakterden fazla olamaz")]
        public string KapiNo { get; set; }
        public int KisiSayisi { get; set; }
        public decimal Fiyat { get; set; }
        public bool CocukIcinUygunMu { get; set; }
    }
}

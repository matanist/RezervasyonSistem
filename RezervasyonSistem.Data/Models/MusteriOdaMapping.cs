using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistem.Data.Models
{
    [Table("MusteriOdaMapping")]
    public class MusteriOdaMapping
    {
        public int Id { get; set; }
        public int OdaId { get; set; }
        public int MusteriId { get; set; }
        public DateTime BaslangicGunu { get; set; }
        public DateTime BitisGunu { get; set; }
        public bool OnaylandiMi { get; set; }
        public decimal ToplamFiyat { get; set; }
        public int ToplamGun { get; set; }
        public Oda Oda { get; set; }
        public Musteri Musteri { get; set; }
    }
}

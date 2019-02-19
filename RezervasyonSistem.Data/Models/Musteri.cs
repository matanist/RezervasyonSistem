using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistem.Data.Models
{
    [Table("Musteri")]
    public class Musteri
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30,ErrorMessage ="30 karakterden fazla olamaz")]
        public string Ad { get; set; }
        [StringLength(30, ErrorMessage = "30 karakterden fazla olamaz")]
        public string Soyad { get; set; }
        [StringLength(20, ErrorMessage = "20 karakterden fazla olamaz")]
        public string Telefon { get; set; }
        [StringLength(100, ErrorMessage = "100 karakterden fazla olamaz")]
        public string Email { get; set; }
    }
}

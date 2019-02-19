using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistem.Data.Models
{
    [Table("OdaResimleri")]
    public class OdaResimleri
    {
        [Key]
        public int Id { get; set; }
        public string DosyaYolu { get; set; }
        public int OdaId { get; set; }

        public Oda Oda { get; set; }
    }
}

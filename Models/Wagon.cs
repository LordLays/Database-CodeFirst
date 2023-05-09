using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonPKP_CodeFirst.Models
{
    public class Wagon
    {
        public string Kod_Wagonu { get; set; }
        public string Kod_Pociagu { get; set; }
        public string Typ_Wagonu { get; set; }
        public int Nr_Wagonu { get; set; }
        public int Ilosc_Miejsc { get; set; }
        public virtual ICollection<Bilet> Bilety { get; set; } = new List<Bilet>();
        [ForeignKey("Kod_Pociagu")]
        public virtual Pociag Pociag { get; set; }
        [ForeignKey("Nazwa")]
        public virtual TypWagonu TypWagonu { get; set; }
    }
}

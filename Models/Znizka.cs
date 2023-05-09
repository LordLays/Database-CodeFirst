using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonPKP_CodeFirst.Models
{
    public class Znizka
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public decimal Wartosc { get; set; }
        public virtual ICollection<Bilet> Bilety { get; set; } = new List<Bilet>();
    }
}

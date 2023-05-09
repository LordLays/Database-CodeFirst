using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonPKP_CodeFirst.Models
{
    public class Pasazer
    {
        public int ID_Pasazera { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public byte Wiek { get; set; }
        public string Ulica { get; set; }
        public short Nr_Domu { get; set; }
        public short? Nr_Mieszkania { get; set; }
        public string Kod_Pocztowy { get; set; }
        public string Miasto { get; set; }
        public string Kraj { get; set; }
        public virtual ICollection<Bilet> Bilety { get; set; } = new List<Bilet>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonPKP_CodeFirst.Models
{
    public class Przystanki
    {
        public int ID_Przystanku { get; set; }
        public string Nazwa { get; set; }
        public int Peron { get; set; }
        public int Tor { get; set; }
        public TimeSpan Przyjazd { get; set; }
        public TimeSpan Odjazd { get; set; }
        public virtual ICollection<Przystanki_Pociagu> Trasy { get; set; } = new List<Przystanki_Pociagu>();
        public virtual ICollection<Status> Statusy { get; set; } = new List<Status>();
        public virtual ICollection<Bilet> Bilety { get; set; } = new List<Bilet>();
    }
}

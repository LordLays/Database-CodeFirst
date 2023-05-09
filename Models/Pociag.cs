using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonPKP_CodeFirst.Models
{
    public class Pociag
    {
        public string Kod_Pociagu { get; set; }
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public string Przewoznik { get; set; }
        public virtual ICollection<Przystanki_Pociagu> Trasy { get; set; } = new List<Przystanki_Pociagu>();
        public virtual ICollection<Wagon> Wagony { get; set; } = new List<Wagon>();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonPKP_CodeFirst.Models
{
    public class Bilet
    {
        public int Nr_Biletu { get; set; }
        [ForeignKey("ID_Pasazera")]
        public virtual int Pasazer { get; set; }
        [ForeignKey("ID_Kursu")]
        public virtual int Kurs { get; set; }
        public DateTime Data_zakupu { get; set; }
        public DateTime Data_podrozy { get; set; }
        public TimeSpan Czas_podrozy { get; set; }
        [ForeignKey("Nazwa")]
        public virtual string Typ_Wagonu { get; set; }
        [ForeignKey("Nr_Wagonu")]
        public virtual string Wagon { get; set; }
        public int Miejsce { get; set; }
        [ForeignKey("ID_Przystanku")]
        public virtual int Stacja_Poczatkowa { get; set; }
        [ForeignKey("ID_Przystanku")]
        public virtual int Stacja_Koncowa { get; set; }
        public bool Sprawdzony { get; set; }
        [ForeignKey("Nazwa")]
        public virtual string Znizka { get; set; }
        public int Naleznosc { get; set; }
    }
}

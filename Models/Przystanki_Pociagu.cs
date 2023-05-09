using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonPKP_CodeFirst.Models
{
    public class Przystanki_Pociagu
    {
        public int ID_Przystanku { get; set; }
        public string Kod_Pociagu { get; set; }
        public TimeSpan Przyjazd { get; set; }
        public TimeSpan Odjazd { get; set; }
        [ForeignKey("ID_Przystanku")]
        public virtual Przystanki Przystanki { get; set; }
        [ForeignKey("Kod_Pociagu")]
        public virtual Pociag Pociag { get; set; }
    }
}

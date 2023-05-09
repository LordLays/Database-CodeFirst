using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonPKP_CodeFirst.Models
{
    public class Status
    {
        public int ID_Statusu { get; set; }
        public TimeSpan Opóźnienie { get; set; }
        public bool Ukonczony { get; set; }
        [ForeignKey("ID_Przystanku")]
        public virtual Przystanki Poprzedni_Przystanek { get; set; }
        [ForeignKey("ID_Przystanku")]
        public virtual Przystanki Nastepny_Przystanek { get; set; }
        public virtual ICollection<Kurs> Kursy { get; set; } = new List<Kurs>();
    }
}

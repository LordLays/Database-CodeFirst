using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonPKP_CodeFirst.Models
{
    public class Kurs
    {
        public int ID_Kursu { get; set; }
        [ForeignKey("Kod_Pociagu")]
        public virtual Pociag Pociag { get; set; }
        [ForeignKey("ID_Statusu")]
        public virtual Status Status { get; set; }
        public TimeSpan Czas_Podrozy { get; set; }
        public DateTime Data { get; set; }
    }
}

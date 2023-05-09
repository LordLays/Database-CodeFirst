using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonPKP_CodeFirst.Models
{
    public class TypWagonu
    {
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
        public virtual ICollection<Wagon> Wagony { get; set; } = new List<Wagon>();
    }
}

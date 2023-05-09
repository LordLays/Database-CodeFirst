using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonPKP_CodeFirst.Models
{
    public class Przewoznik
    {

        public string Nazwa { get; set; }
        public virtual ICollection<Pociag> Pociagi { get; set; }
    }
}

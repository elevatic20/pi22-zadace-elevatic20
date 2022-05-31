using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReservate.Models
{
    public class Gost
    {
        public string OIB { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;

        }

        public string Kontakt { get; set; }
    }
}

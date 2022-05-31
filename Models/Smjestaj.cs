using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReservate.Models
{
    public class Smjestaj
    {
        public int Id_smjetaj { get; set; }
        public string Naziv_smjestaja { get; set; }

        public override string ToString()
        {
            return Naziv_smjestaja;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrogMusicFest.Models
{
    public class Izvodjac
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string VrstaMuzike { get; set; }
        public DateTime DanNastupa { get; set; }
        public DateTime? VremeNastupa { get; set; }

        //public string Image { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Course.Entities
{
    public class Inscription
    {
        public int EtudiantId { get; set; }
        public int CourId { get; set; }
        public int Year { get; set; }
    }
}

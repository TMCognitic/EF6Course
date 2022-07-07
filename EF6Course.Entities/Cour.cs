using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Course.Entities
{
    public class Cour
    {
        public int Id { get; set; }
        public string? Titre { get; set; }
        public int Periode { get; set; }
    }
}

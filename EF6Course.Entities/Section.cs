using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Course.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string? Nom { get; set; }

        //Propriété de navigation
        public virtual IEnumerable<Etudiant> Etudiants { get; set; } = new List<Etudiant>();
    }
}

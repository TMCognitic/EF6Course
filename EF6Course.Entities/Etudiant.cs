namespace EF6Course.Entities
{
    public class Etudiant
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Email { get; set; }
        public DateTime DateInscription { get; set; }
        public int Resultat { get; set; }
        public int SectionId { get; set; }

        //Propriété de navigation
        public Section? Section { get; set; }
        public virtual IEnumerable<Cour> Cours { get; set; } = new List<Cour>();
    }
}
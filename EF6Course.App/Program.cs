using EF6Course.Context;
using EF6Course.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF6Course.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversiteContext context = new UniversiteContext();
            //Etudiant student = new Etudiant() { Nom = "Van Langenhove", Prenom = "Tony", Email = "tony.vanlangenhove@gmail.com", SectionId = 1, Resultat = 12 };
            //context.Add(student);
            //context.SaveChanges();




            //Section? section = context.Sections.Include(s => s.Etudiants).SingleOrDefault(s => s.Id == 1);

            //if (section is not null)
            //{                
            //    Console.WriteLine($"{section.Id:D4} : {section.Nom} : ");
            //    //context.Entry(section).Collection(s => s.Etudiants).Load();
            //    foreach (Etudiant st in section.Etudiants)
            //    {
            //        Console.WriteLine($"{st.Prenom} {st.Nom}");
            //    }
            //}

            //Etudiant? etudiant = context.Etudiants.Find(1);
            //if(etudiant is not null)
            //    Console.WriteLine(etudiant.Section!.Nom);
        }
    }
}
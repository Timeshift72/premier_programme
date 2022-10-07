using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace premier_programme
{
    class Program
    {
        static int DemanderAge(string nom)
        {
            int age_num = 0;
            while (age_num <= 0)
            {
                Console.Write("Quel est l'age de "+ nom +" ? ");
                string age_str = Console.ReadLine();

                try
                {
                    age_num = int.Parse(age_str);

                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas être négatif");
                    }
                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas être égal à 0");
                    }

                }
                catch
                {
                    Console.WriteLine("Erreur, vous devez rentrer un age valide.");
                }

            }
            return age_num;
        }
        static string DemanderNom(int numeroPersonne)
        {
            string nom = "";
            while (nom == "")
            {
                Console.Write("Quel est le prénom de la personne numéro "+ numeroPersonne+" ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();
                if (nom == "")
                {
                    Console.WriteLine("Erreur : le prénom ne doit pas être vide");
                }

            }
            return nom;
        }
        static void Main (string[] args)
        {
            // Pour afficher les accents
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //ON DEMANDE LE PRENOM

            string nom1 = DemanderNom(1);
            string nom2 = DemanderNom(2);

            //ON DEMANDE L'AGE

            int age1 = DemanderAge(nom1);
            int age2 = DemanderAge(nom2);

            Console.WriteLine();
            Console.WriteLine("Bonjour vous vous appelez " + nom1 + ", vous avez " + age1 + " ans.");
            Console.WriteLine("Bientôt vous aurez " + (age1+1) + " ans");

            Console.WriteLine();
            Console.WriteLine("Bonjour vous vous appelez " + nom2 + ", vous avez " + age2 + " ans.");
            Console.WriteLine("Bientôt vous aurez " + (age2 + 1) + " ans");
        }

    }
}

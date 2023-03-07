using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Veuillez saisir votre salaire annuel : ");
        double salaireAnnuel = double.Parse(Console.ReadLine());

        double[] salairesMensuels = new double[12];

        double salaireMensuelBase = salaireAnnuel / 12;

        for (int i = 0; i < 11; i++)
        {
            salairesMensuels[i] = salaireMensuelBase;
        }

        double primeNoel = 0;

        try
        {
            Console.Write("Veuillez saisir le montant en pourcentage de la prime de Noël : ");
            string pourcentagePrimeNoel = Console.ReadLine();

            primeNoel = double.Parse(pourcentagePrimeNoel) / 100 * salaireAnnuel;
        }
        catch (FormatException)
        {
            Console.WriteLine("Erreur : vous devez entrer un nombre entier pour le pourcentage de la prime de Noël.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erreur : le pourcentage de la prime de Noël ne peut pas être égal à 0.");
        }

        double salaireDecembre = salaireMensuelBase + (salaireAnnuel * 0.1) / 12 + primeNoel;
        salairesMensuels[11] = salaireDecembre;

        string[] moisDeLannee = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

        for (int i = 0; i < 12; i++)
        {
            if (i == 7)
            {
                Console.WriteLine(moisDeLannee[i] + " : entreprise fermée");
            }
            else
            {
                Console.WriteLine(moisDeLannee[i] + " : " + salairesMensuels[i] + "€");
            }
        }

        Console.ReadLine();
    }
}


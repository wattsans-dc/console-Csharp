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

        double salaireDecembre = salaireMensuelBase + (salaireAnnuel * 0.1) / 12;
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

using System;

class Program
{
    static void Main()
    {
        Console.Write("Saisir le salaire brut annuel : ");
        double salaireBrutAnnuel = double.Parse(Console.ReadLine());

        Console.Write("Saisir le taux d'imposition (en pourcentage) : ");
        double tauxImposition = double.Parse(Console.ReadLine()) / 100.0;

        double salaireNetMensuel = (salaireBrutAnnuel / 12) * (1 - tauxImposition);

        Console.WriteLine("Le salaire net mensuel est de {0:F2} euros.", salaireNetMensuel);
    }
}

using System;

class condition
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrez votre salaire brut : ");
        int salaire = 0;

        if (!int.TryParse(Console.ReadLine(), out salaire))
        {
            Console.WriteLine("Salaire invalide. Veuillez entrer un nombre entier.");
            return;
        }

        Console.WriteLine("Entrez votre taxe : ");
        int taxe = 0;

        if (!int.TryParse(Console.ReadLine(), out taxe))
        {
            Console.WriteLine("Taxe invalide. Veuillez entrer un nombre entier.");
            return;
        }

        if (salaire < 0 || taxe < 0)
        {
            Console.WriteLine("Le salaire et la taxe doivent être des nombres positifs.");
            return;
        }

        if (salaire >= 50000)
        {
            Console.WriteLine("Votre salaire dépasse 50 000 euros par an. Nous vous conseillons de faire des dons pour réduire vos impôts.");
        }
        else if (salaire < 1500)
        {
            Console.WriteLine("Votre salaire mensuel brut est en dessous de 1500 euros. C'est normal pour un alternant.");
        }
        else if (salaire >= 30000 && salaire <= 40000)
        {
            Console.WriteLine("Votre salaire brut est compris entre 30 000 et 40 000 euros par an. Nous vous conseillons de venir à CESI pour un boost de +5 en développement.");
        }
        else
        {
            Console.WriteLine("Votre salaire est dans une fourchette normale.");
        }
    }
}

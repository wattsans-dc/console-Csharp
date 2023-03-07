using System;



class Employee
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
    public double Tax { get; set; }


    public Employee()
    {
        Console.Write("Entrez votre identifiant : ");
        this.Id = int.Parse(Console.ReadLine());

        Console.Write("Entrez votre prénom : ");
        this.Firstname = Console.ReadLine();

        Console.Write("Entrez votre nom de famille : ");
        this.Lastname = Console.ReadLine();

        Console.Write("Entrez votre âge : ");
        this.Age = int.Parse(Console.ReadLine());

        Console.Write("Entrez votre salaire annuel : ");
        this.Salary = double.Parse(Console.ReadLine());

        Console.Write("Entrez le montant en pourcentage de vos taxes annuelles : ");
        this.Tax = double.Parse(Console.ReadLine());

    }

    public void ChooseOption()
    {
        Console.WriteLine("Choisissez une option : ");
        Console.WriteLine("1. Afficher votre salaire mensuel");
        Console.WriteLine("2. Calculer vos intérêts composés");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            PrintMonthlySalary();
        }
        else if (choice == 2)
        {
            CalculateCompoundInterest();
        }
    }

    public void CalculateCompoundInterest()
    {
        Console.Write("Entrez le capital investi : ");
        double capital = double.Parse(Console.ReadLine());

        Console.Write("Entrez le taux d'intérêt annuel : ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Entrez le nombre d'années : ");
        int years = int.Parse(Console.ReadLine());

        double balance = capital;

        Console.WriteLine($"Année 1 : {balance.ToString("N2")} €");

        for (int i = 2; i <= years; i++)
        {
            balance *= 1 + rate / 100;
            Console.WriteLine($"Année {i} : {balance.ToString("N2")} €");
        }
    }

    public void PrintMonthlySalary()
    {
        double[] monthlySalaries = new double[12];

        double baseMonthlySalary = this.Salary / 12;

        for (int i = 0; i < 11; i++)
        {
            monthlySalaries[i] = baseMonthlySalary;
        }

        double christmasBonus = 0;

        try
        {
            Console.Write("Entrez le montant en pourcentage de votre prime de Noël : ");
            string christmasBonusPercentage = Console.ReadLine();

            christmasBonus = double.Parse(christmasBonusPercentage) / 100 * this.Salary;
        }
        catch (FormatException)
        {
            Console.WriteLine("Erreur : vous devez entrer un nombre entier pour le pourcentage de la prime de Noël.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erreur : le pourcentage de la prime de Noël ne peut pas être égal à 0.");
        }

        double decemberSalary = baseMonthlySalary + (this.Salary * 0.1) / 12 + christmasBonus;
        monthlySalaries[11] = decemberSalary;

        string[] months = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

        Console.WriteLine($"Voici les salaires mensuels pour {this.Firstname} {this.Lastname} ({this.Age} ans) :");

        for (int i = 0; i < 12; i++)
        {
            if (i == 7)
            {
                Console.WriteLine(months[i] + " : entreprise fermée");
            }
            else
            {
                double netSalary = monthlySalaries[i] * (1 - this.Tax / 100);
                Console.WriteLine(months[i] + " : " + netSalary.ToString("N2") + "€ net");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.ChooseOption();

        Console.ReadLine();
    }

}

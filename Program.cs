using System;
using System.Globalization;
using Primeiro.Entities;

namespace Primeiro
{
    class Program
    {
       static void Main()
        { 
            // Instaciar a lista 
            List<PhysicalPerson> list = new List<PhysicalPerson>();
            
            // entrada de dados  
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            // processamento de dados 
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Campany (i/c) ");
                char cha = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income : ");
                double anualIncome = double.Parse(Console.ReadLine());

               if (cha == 'c')
               {
                    Console.Write("Number of Employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(name, anualIncome, employees));
               } 
               else
               {
                    Console.Write("Health expenditures: ");
                    double healthIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                    list.Add(new HealthSpending(name, anualIncome, healthIncome));
               }                
            }

            // saida de dados
           
           double sum = 0.0;
           Console.WriteLine();
           Console.WriteLine("TAXES PAID");
           foreach (PhysicalPerson person in list)
           {
              double tax = person.TaxCollection();
              Console.WriteLine($"{person.Name}: $ {person.TaxCollection().ToString("F2", CultureInfo.InvariantCulture)}");
              sum += tax; 
           }
 
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}


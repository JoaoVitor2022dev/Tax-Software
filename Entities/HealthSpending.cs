using System;
using System.Globalization;

namespace Primeiro.Entities
{
    class HealthSpending : PhysicalPerson
    {
         public double HealthIncome { get; set; }
         public HealthSpending()
         {}
         public HealthSpending(string name, double annualIncome, double healthIncome):
         base(name, annualIncome)
         {
             HealthIncome = healthIncome;
         }
        public override double TaxCollection()
        {
           if (AnnualIncome < 20000.0)
           {
             return  AnnualIncome * 0.15  -  AnnualIncome * 0.50;
           } 
           else  
           { 
             return  AnnualIncome * 0.25 - AnnualIncome * 0.50 ;
           }
        }
    }
}
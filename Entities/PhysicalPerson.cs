using System;
using System.Globalization;

namespace Primeiro.Entities
{
    abstract class PhysicalPerson
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }
        public PhysicalPerson()
        {}
        public PhysicalPerson(string name, double annualIncome)
        {
            Name = name; 
            AnnualIncome = annualIncome; 
        }
        public abstract double TaxCollection();
    }
}
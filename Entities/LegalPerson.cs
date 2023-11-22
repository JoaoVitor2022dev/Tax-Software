using System;
using System.Globalization;

namespace Primeiro.Entities
{
    class LegalPerson : PhysicalPerson
    {
        public int NumberEmployees { get; set; }
        public LegalPerson()
        {}
        public LegalPerson(string name, double annualIncome,int numberEmployees): 
        base(name, annualIncome)
        {
           NumberEmployees = numberEmployees;
        }
        public override double TaxCollection()
        {
            if (NumberEmployees > 10)
            {
                return AnnualIncome * 0.14; 
            } 
            else
            {
                return AnnualIncome * 0.16;
            } 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLs2Employee
{
    class Employee
    {
        readonly public string surname, name;
        const int MIN_WAGE = 6500;
        public string JobPosition { get; set; }
        public double Seniority { get; set; }
        public double Wage { get; set; }
        public double Tax { get; set; }
        public double CoefWage { get; set; }
        public double CoefTax { get; set; }
        public void CalculateCoefWage()
        {
            double coef = 1;
            switch (JobPosition)
            {
                case "director":
                    coef *= 5;
                    break;
                case "head of department":
                    coef *= 3.5;
                    break;
                case "manager":
                    coef *= 2;
                    break;
                case "worker":
                    coef *= 1.5;
                    break;
                default:
                    coef *= 1;
                    break;
            }
            if (Seniority < 10)
            {
                coef *= 1;
            }
            else if (Seniority >= 10 && Seniority < 20)
            {
                coef *= 2.5;
            }
            else if (Seniority >= 20 && Seniority < 30)
            {
                coef *= 3.5;
            }
            else if (Seniority >= 30 && Seniority < 40)
            {
                coef *= 2;
            }
            else
            {
                coef *= 1;
            }
            CoefWage = coef;
        }
        public void CalculateCoefTax()
        {
            double coef = 0.15; 
            if (Wage < 10000)
            {
                coef *= 1;
            }
            else if (Seniority >= 10000 && Seniority < 20000)
            {
                coef *= 1.2;
            }
            else if (Seniority >= 20000 && Seniority < 40000)
            {
                coef *= 1.5;
            }
            else if (Seniority >= 40000 && Seniority < 60000)
            {
                coef *= 1.8;
            }
            else
            {
                coef *= 2;
            }
            CoefTax = coef;
        }
        public void CalculateWage()
        {
            CalculateCoefWage();
            Wage = MIN_WAGE * CoefWage;
        }
        public void CalculateTax()
        {
            CalculateWage();
            CalculateCoefTax();
            Tax = Wage * CoefTax;
        }
        public Employee() { }
        public Employee(string enterSurname, string enterName)
        {
            surname = enterSurname;
            name = enterName;
        }
    }
}

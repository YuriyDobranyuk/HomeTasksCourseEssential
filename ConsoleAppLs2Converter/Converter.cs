using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLs2Converter
{
    class Converter
    {
        readonly double courseUsd, courseEur, courseRub;
        public string IndexTypeOperation { get; set; }
        public string IndexTypeCurrency { get; set; }
        public string TypeOperation { get; set; }
        public string TypeCurrency { get; set; }
        public double CurrencyCount { get; set; }
        public double CourseCurrency { get; set; }
        public double ResultConvertCurrency { get; set; }
        public void ConvertCurrency()
        {
            SetCourseCurrency();
            SetTypeCurrency();
            SetTypeOperation();
            if (IndexTypeOperation == "1")
            {
                ResultConvertCurrency = CurrencyCount / CourseCurrency;
            }
            else if (IndexTypeOperation == "2")
            {
                ResultConvertCurrency = CurrencyCount * CourseCurrency;
            }
        }
        public void SetCourseCurrency()
        {
            if (IndexTypeCurrency == "1")
            {
                CourseCurrency = courseUsd;
            }
            else if (IndexTypeCurrency == "2")
            {
                CourseCurrency = courseEur;
            }
            else if (IndexTypeCurrency == "3")
            {
                CourseCurrency = courseRub;
            }
        }
        public void SetTypeCurrency()
        {
            if(IndexTypeCurrency == "1")
            {
                TypeCurrency = "USD";
            }
            else if (IndexTypeCurrency == "2")
            {
                TypeCurrency = "EUR";
            }
            else if(IndexTypeCurrency == "3")
            {
                TypeCurrency = "RUB";
            }
        }
        public void SetTypeOperation()
        {
            if(IndexTypeOperation == "1")
            {
                TypeOperation = "currency purchase";
            }
            else if (IndexTypeOperation == "2")
            {
                TypeOperation = "sale of currency";
            }
        }
        public void Show()
        {
            Console.WriteLine(new String('*', 20));
            Console.WriteLine("Result convert currency:");
            Console.WriteLine($"Type operation: {TypeOperation}.");
            Console.WriteLine($"Type currency for convert: {TypeCurrency}.");
            Console.WriteLine($"Course convert for {TypeCurrency} by UAH: {CourseCurrency}.");
            Console.WriteLine($"Count currency: {CurrencyCount}.");
            Console.WriteLine($"Result convert: {ResultConvertCurrency}.");
            Console.WriteLine(new String('*', 20));
        }
        
        public Converter() { }
        public Converter(double usd, double eur, double rub)
        {
            courseUsd = usd;
            courseEur = eur;
            courseRub = rub;
        }
    }
}

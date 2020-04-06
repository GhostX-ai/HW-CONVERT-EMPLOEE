using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter som money:");
            double som = double.Parse(Console.ReadLine());
            Console.WriteLine("Chose currency\n1 usd\n2 eur\n3 rub");
            int ch = int.Parse(Console.ReadLine());
            Money mn = new Money() { eur = 11.02, rub = 0.13, usd = 10.98 };
            switch (ch)
            {
                case 1:
                    {
                        System.Console.WriteLine("$ "+mn.ToUsd(som));
                        System.Console.WriteLine("som "+mn.FromUsd(som));
                    }
                    break;
                case 2:
                    {
                        System.Console.WriteLine("eur "+mn.ToEur(som));
                        System.Console.WriteLine("som "+mn.FromEur(som));
                    }
                    break;
                case 3:
                    {
                        System.Console.WriteLine("rub "+mn.ToRub(som));
                        System.Console.WriteLine("som "+mn.FromRub(som));
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
    public class Money
    {
        public double usd { get; set; }
        public double eur { get; set; }
        public double rub { get; set; }
        public Money()
        {

        }
        public Money(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public double ToUsd(double som)
        {
            return som / usd;
        }
        public double FromUsd(double som)
        {
            return ToUsd(som) * usd;
        }
        public double ToEur(double som)
        {
            return som / eur;
        }
        public double FromEur(double som)
        {
            return ToEur(som) * eur;
        }
        public double ToRub(double som)
        {
            return som / rub;
        }
        public double FromRub(double som)
        {
            return ToRub(som) * rub;
        }
    }
}

using System;
using System.Xml.Schema;
namespace Learning03;
class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        for (int i = 0; i < 20; i++){
            Random rnd = new Random();
            f.SetTop(rnd.Next(1, 101));
            f.SetBottom(rnd.Next(1, 101));
            string frac = f.GetFractionString();
            double dec = f.GetDecimalValue();
            Console.WriteLine($"Fraction: String: {frac}, Decimal: {dec}");
        }
    }
}

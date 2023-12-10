using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalListeUdregning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers(9);

            numbers.AddNumber(3);
            numbers.AddNumber(5);
            numbers.AddNumber(7);

            Console.WriteLine("Tallene i listen: " + numbers.ToString());
            Console.WriteLine("Antal af numre i listen: " + numbers.GetCount());
            Console.WriteLine("Summen af alle tal i listen: " + numbers.GetSum());
            Console.WriteLine("Gennemsnittet af tallene i listen: " + numbers.GetAverage());
            Console.WriteLine("Summen af alle tal i listen: " + numbers.GetSum());
            Console.WriteLine("Det mindste af tallene i listen: " + numbers.GetMin());
            Console.WriteLine("Det største af tallene i listen: " + numbers.GetMax());

            Console.ReadLine();
        }
    }
}

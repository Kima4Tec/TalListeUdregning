using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalListeUdregning
{
    public class Numbers
    {
        //En liste af navnet Numbers, som kan indeholde heltal
        List<int> numbers;

        //En contructor uden parametre
        public Numbers()
        {

        }

        //En constructor med et tal som parameter, som skal indsættes som det første tal i listen
        public Numbers(int firstNumber)
        {
            numbers = new List<int>();
            numbers.Add(firstNumber);
        }

        //AddNumber med et tal som parameter, der indsættes i listen
        public void AddNumber(int aNumber)
        {
            numbers.Add(aNumber);
        }

        //GetCount, som returnerer antallet af tal i liste
        public int GetCount()
        {
            return numbers.Count;
        }

        //GetSum, som returnerer summen af alle tal i listen
        public int GetSum()
        {
            int sum = numbers.Sum();
            return sum;
        }

        //GetAverage, som returnerer gennemsnittet af alle tals værdier
        public double GetAverage()
        {
            double avg = numbers.Average();
            return avg;
        }

        //GetMin, som returnerer det mindste tal i listen
        public int GetMin()
        {
            int min = numbers.Min();
            return min;
        }

        //GetMax, som returnerer det største tal i listen
        public int GetMax()
        {
            int max = numbers.Max();
            return max;
        }


        //ToString, som returnerer en string med alle talværdier
        public override string ToString()
        {
                return string.Join(", ", numbers);

        }

    }
}

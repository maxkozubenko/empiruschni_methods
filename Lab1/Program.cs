using System;
using MathStat;


namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            listNumbers ls = new listNumbers();
            ls.GetListX();
            ls.GetListY();
            Console.WriteLine("///////////////////////");
            ls.StaticDivide(150.00);
            Console.WriteLine("///////////////////////");
            ls.IntervalValue();
            Console.WriteLine("///////////////////////");
            ls.FindSomevaluesX_Y();
            Console.WriteLine("///////////////////////");
            ls.GetIntervalBorder();

        }
    }
}

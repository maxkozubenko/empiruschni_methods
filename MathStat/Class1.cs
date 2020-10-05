using System;
using System.Collections.Generic;
using System.IO;

namespace MathStat
{
    public class listNumbers
    {
        public List<double> listX = new List<double>();
        public List<double> listY = new List<double>();
        public int NumberN;
        public double maxX, minX, maxY, minY, delX, delY;
        public double Xl, Xr, Yl, Yr;
        public List<double> listYLi = new List<double>();
        public List<double> listXLi = new List<double>();

        public void GetListX()
        {
            string[] lines = File.ReadAllLines("D:/Curse-4(1)/Емпіричні методи програмної інженерії/Лаби/Завдання/Лабораторна робота 1/info.txt");
            for (int i = 0; i < 150; i++)
            {
                string res = null;

                if (i < 10)
                {
                    res = lines[i].Substring(3);
                }
                else if (i < 100)
                {
                    res = lines[i].Substring(4);
                }
                else if (i >= 100)
                {
                    res = lines[i].Substring(5);
                }
                listX.Add(Convert.ToDouble(res));
            }

            foreach (double item in listX)
            {
                Console.WriteLine(item);
            }
        }
        public void GetListY()
        {
            string[] lines = File.ReadAllLines("D:/Curse-4(1)/Емпіричні методи програмної інженерії/Лаби/Завдання/Лабораторна робота 1/info.txt");
            for (int i = 150; i < 300; i++)
            {
                string res = null;

                if (i < 160)
                {
                    res = lines[i].Substring(3);
                }
                else if (i < 250)
                {
                    res = lines[i].Substring(4);
                }
                else if (i >= 250)
                {
                    res = lines[i].Substring(5);
                }
                listY.Add(Convert.ToDouble(res));
            }

            foreach (double item in listY)
            {
                Console.WriteLine(item);
            }
        }

        // Побудова статистичного розподілу
        public void StaticDivide(double n)
        {
            int res = 2 + Convert.ToInt32((3.322 * Math.Log10(n)));
            Console.WriteLine(res);
            NumberN = res;
        }

        // Знайдемо величину інтервалу
        public void IntervalValue()
        {
            listX.Sort();
            listY.Sort();

            minX = listX[0];
            maxX = listX[listX.Count - 1];
            minY = listY[0];
            maxY = listY[listY.Count - 1];

            delX = ((maxX - minX) / (NumberN - 1));
            delY = ((maxY - minY) / (NumberN - 1));

            //Console.WriteLine(minX);
            //Console.WriteLine(maxX);
            //Console.WriteLine(minY);
            //Console.WriteLine(maxY);
            Console.WriteLine(delX);
            Console.WriteLine(delY);
        }

        // Знайдемо Х(праве і ліве) те саме Y
        public void FindSomevaluesX_Y()
        {
            Xl = minX - (delX / 2);
            Xr = maxX - (delX / 2);
            Yl = minY - (delY / 2);
            Yr = maxY - (delY / 2);

            Console.WriteLine(Xl + "\n" + Xr + "\n" + Yl + "\n" + Yr);
        }

        public void GetIntervalBorder()
        {
            for (int i = 1; i < NumberN + 1; i++)
            {
                double res = Xl + (i - 1) * delX;
                if (i != 1)
                {
                    res -= 0.001;
                    listXLi.Add(Math.Round(res, 3));
                }
                res += 0.001;
                listXLi.Add(Math.Round(res, 3));

                if (NumberN == (i + 1))
                {
                    listXLi.Add(Xr);
                }
            }
            foreach (double item in listXLi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("++++++++++++++++++");
            for (int i = 1; i < NumberN + 1; i++)
            {
                double res = Yl + (i - 1) * delY;
                if (i != 1)
                {
                    res -= 0.001;
                    listYLi.Add(Math.Round(res, 3));
                }
                res += 0.001;
                listYLi.Add(Math.Round(res, 3));
            }
            foreach (double item in listYLi)
            {
                Console.WriteLine(item);
            }
        }
    }
}

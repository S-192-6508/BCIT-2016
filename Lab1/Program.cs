using System;

namespace LR1
{
    #region Par
    class Parameters
    {
        public float[] a;
        public void ParametersControl()
        {
            {
                Console.WriteLine("Значнеия параметров:\n      A = {0}\n      B = {1}\n      C = {2}", a[0], a[1], a[2]);
                Console.ReadKey(true);
            }
        }
        public void ParamReader()
        {
            string c;
            a = new float[3];
            bool control;
            for (int i = 0; i <= 2; i = i + 1)
            {
                switch (i)
                {
                    case 0: { Console.WriteLine("Введите параметр A(int)."); break; }
                    case 1: { Console.WriteLine("Введите параметр B(int)."); break; }
                    case 2: { Console.WriteLine("Введите параметр C(int)."); break; }
                }
                control = false;
                while (control != true)
                {
                    c = Console.ReadLine();
                    control = float.TryParse(c, out a[i]);
                    if (control == false)
                    {
                        Console.WriteLine("Ошибка! Введено не число. Введите параметр снова.");
                        c = Console.ReadLine();
                        control = float.TryParse(c, out a[i]);
                    }
                }
            }
        }
    }
    #endregion Par
    #region Calc
    class Calculator
    {
        public void CalculatorD(float a, float b, float c)
        {
            if ((a == 0) & (b == 0) & (c == 0)) //1
            {
                Console.WriteLine("0 = 0, X - любое число.");
            }
            if ((a == 0) & (b == 0) & (c != 0)) //2
            {
                Console.WriteLine("0 = {0}, Нет решений.", c);
            }
            if ((a == 0) & (b != 0) & (c == 0)) //3
            {
                Console.WriteLine("0 = {0}*Х, Х = 0.", b);
            }
            if ((a == 0) & (b != 0) & (c != 0)) //4
            {
                Console.WriteLine("{0} = {1}*Х, Х = {2}.", b, (-c), (-c / b));
            }
            if ((a != 0) & (b == 0) & (c == 0)) //5
            {
                Console.WriteLine("0 = {0}*Х^2, Х = 0.", a);
            }
            if ((a != 0) & (b == 0) & (c != 0)) //6
            {
                if (c < 0) Console.WriteLine("{0}*Х^2 = {1}, Х = {2} ", a, (-c), (Math.Sqrt(-c / a)));
                else Console.WriteLine("{0}X^2 = {1}, Х = {2}*i ", a, (-c), (Math.Sqrt(c / a)));
            }
            if ((a != 0) & (b != 0) & (c == 0)) //7
            {
                Console.WriteLine("{0}*Х^2 + {1}*Х = 0, Х = 0, Х = {2} ", a, b, (-b / a));
            }
            if ((a != 0) & (b != 0) & (c != 0)) //8
            {
                float D;
                D = b * b - 4 * a * c;
                if (D == 0) Console.WriteLine("D = {0}, Х = {1} ", D, (-b / (2 * a)));
                if (D > 0) Console.WriteLine("D = {0}, Х = {1},      Х = {2} ", D, ((-b + Math.Sqrt(D)) / (2 * a)), ((-b - Math.Sqrt(D)) / (2 * a)));
                if (D < 0) Console.WriteLine("D = {0}, Х = {1} + {2}*i,      Х ={1} - {2}*i ", D, (-b / (2 * a)), (Math.Sqrt(-D) / (2 * a)));
            }
        }
    }
    #endregion Calc
    class Program
    {
        public static void Main(string[] args)
        {
            Parameters NP = new Parameters();
            Calculator C = new Calculator();
            NP.ParamReader();
            NP.ParametersControl();
            C.CalculatorD(NP.a[0], NP.a[1], NP.a[2]);
            Console.ReadKey(true);
        }
    }
}

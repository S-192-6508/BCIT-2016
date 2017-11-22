using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LR2
{
    abstract class GeometricalFigure
    {
        public string Property1
        {
            get
            {
                return this._Property1;
            }
            protected set
            {
                this._Property1 = value;
            }
        }
        string _Property1;
        public abstract double Area();
        public override string ToString()
        {
            return this.Property1 + " площадью " + this.Area().ToString();
        }
    }

    interface IPrint
    {
        void Print();
    }

    class Polygon : GeometricalFigure, IPrint
    {
        double rad;
        int sides;
        public Polygon(double pr, int n)
        {
            this.rad = pr;
            this.sides = n;
            this.Property1 = n.ToString() + " - угольник";
        }
        public override double Area()
        {
            double Result = this.rad * Math.Cos(Math.PI / this.sides) * this.sides * this.rad * Math.Sin(Math.PI / this.sides);
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Circle : GeometricalFigure, IPrint
    {
        double rad;
        public Circle(double pr)
        {
            this.rad = pr;
            this.Property1 = "Круг";
        }
        public override double Area()
        {
            double Result = Math.PI * this.rad * this.rad;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
   
    class Rectangle : GeometricalFigure, IPrint
    {
        double he;
        double wi;
        public Rectangle(double ph, double pw)
        {
            this.he = ph;
            this.wi = pw;
            this.Property1 = "Прямоугольник";
        }
        public override double Area()
        {
            double Result = this.wi * this.he;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Square : Rectangle, IPrint
    {
        public Square(double size)
            : base(size, size)
        {
            this.Property1 = "Квадрат";
        }
    }

    class FigureData
    {
        public int a;
        public double A, B, R;
        public int n;
        public int FigureChose()
        {
            string c;
            bool Err = false;
            while (Err != true)
            {
                Console.WriteLine("Для какой фигуры будет просчитываться площадь?\n    1.Круг.\n    2.Прямоугольник.\n    3.Квадрат.\n    4.Многоугольник.\n\n");
                c = Console.ReadLine();
                Err = int.TryParse(c, out a);
                if ((Err == false) || (a > 4) || (a < 1))
                {
                    Console.WriteLine("Ошибка! Неправильно выбран режим работы.");
                    Err = false;
                }
                else Err = true;
            }
            return a;
        }
        public void FigureParameters()
        {
            string c;
            switch (a)
            {
                case 1:
                    {
                        bool Err = false;
                        while (Err != true)
                        {
                            Console.WriteLine("Введите значение радиуса.\n");
                            c = Console.ReadLine();
                            Err = double.TryParse(c, out R);
                            if ((Err == false) || (R <= 0))
                            {
                                Console.WriteLine("Ошибка!! Неправильно введено значение.");
                                Err = false;
                            }
                            else Err = true;
                        }
                        break;
                    }
                case 2:
                    {
                        bool Err = false;
                        while (Err != true)
                        {
                            Console.WriteLine("Введите значение высоты.\n");
                            c = Console.ReadLine();
                            Err = double.TryParse(c, out A);
                            if ((Err == false) || (A <= 0))
                            {
                                Console.WriteLine("Ошибка! Неправильно введено значение.");
                                Err = false;
                            }
                            else Err = true;
                        }
                        Err = false;
                        while (Err != true)
                        {
                            Console.WriteLine("Введите значение ширины.\n");
                            c = Console.ReadLine();
                            Err = double.TryParse(c, out B);
                            if ((Err == false) || (B <= 0))
                            {
                                Console.WriteLine("Ошибка! Неправильно введено значение.");
                                Err = false;
                            }
                            else Err = true;
                        }
                        break;
                    }
                case 3:
                    {
                        bool Err = false;
                        while (Err != true)
                        {
                            Console.WriteLine("Введите значение длины стороны.\n");
                            c = Console.ReadLine();
                            Err = double.TryParse(c, out A);
                            if ((Err == false) || (A <= 0))
                            {
                                Console.WriteLine("Ошибка! Неправильно введено значение.");
                                Err = false;
                            }
                            else Err = true;
                        }
                        break;
                    }
                case 4:
                    {
                        bool Err = false;
                        while (Err != true)
                        {
                            Console.WriteLine("Введите значение радиуса оисанной окружности.\n");
                            c = Console.ReadLine();
                            Err = double.TryParse(c, out R);
                            if ((Err == false) || (R <= 0))
                            {
                                Console.WriteLine("Ошибка! Неправильно введено значение.");
                                Err = false;
                            }
                            else Err = true;
                        }
                        Err = false;
                        while (Err != true)
                        {
                            Console.WriteLine("Введите количество сторон (больше 2).\n");
                            c = Console.ReadLine();
                            Err = int.TryParse(c, out n);
                            if ((Err == false) || (n <= 2))
                            {
                                Console.WriteLine("Ошибка! Неправильно введено значение.");
                                Err = false;
                            }
                            else Err = true;
                        }
                        break;
                    }
            }

        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            int FT;
            FigureData FC = new FigureData();
            FT = FC.FigureChose();
            FC.FigureParameters();
            Rectangle rect = new Rectangle(FC.A, FC.B);
            Square square = new Square(FC.A);
            Circle circle = new Circle(FC.R);
            Polygon polyg = new Polygon(FC.R, FC.n);

            switch (FT)
            {
                case 1: { circle.Print(); break; }
                case 2: { rect.Print(); break; }
                case 3: { square.Print(); break; }
                case 4: { polyg.Print(); break; }
            }
            Console.ReadKey(true);
        }
    }
} 


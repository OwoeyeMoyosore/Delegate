using System;

namespace LearnCSharp.Cmd
{
    public delegate int Arithmetic<Z,Y>(Z first, Y second);
    public delegate void ArithmeticDelegate();

    public delegate Shape DrawDelegate();
    public delegate void ShapeDelegate(int i);

    public class Shape
    {

    }

    public class Triangle : Shape
    {

    }
    public class Program
    {

        static Triangle DrawTriangle()
        {
            return new Triangle();
        }

        static void Main()
        {
            ShapeDelegate shapeDelegate = i =>
            {
                Console.WriteLine(i);
            };

            ArithmeticDelegate arithmeticDelegate = () =>
            {

            };
           
                DrawDelegate drawDelegate = DrawTriangle;

            Arithmetic<int, int> del = Add;//Generic Delegate
            del += Minus;
            

            //Anonymous delegate method
            del += delegate (int first, int second)
            {
                return first+ second;
            };

            //lambda expression
            del += (first, second) =>
            {
                return second + first;
            };
            del += (first, second) => second + first;

            var result = del(39, 8);
            Console.WriteLine(result);

            //Console.WriteLine("+++++++++++++++++");
            //del -= MyMethod2;
            //del(80);

        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Minus(int x, int y)
        {
            return x - y;
        }

    }
}
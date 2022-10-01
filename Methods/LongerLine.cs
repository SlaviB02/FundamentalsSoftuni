using System;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            double X3 = double.Parse(Console.ReadLine());
            double Y3 = double.Parse(Console.ReadLine());
            double X4 = double.Parse(Console.ReadLine());
            double Y4 = double.Parse(Console.ReadLine());
            if (Distance(X1,Y1,X2,Y2)>=Distance(X3,Y3,X4,Y4))
            {
                if(Closer(X1,Y1)<=Closer(X2,Y2))
                {
                    Console.WriteLine($"({X1}, {Y1})({X2}, {Y2})");
                }
                else
                {
                    Console.WriteLine($"({X2}, {Y2})({X1}, {Y1})");
                }
            }
            else
            {
                if (Closer(X3, Y3) <= Closer(X4, Y4))
                {
                    Console.WriteLine($"({X3}, {Y3})({X4}, {Y4})");
                }
                else
                {
                    Console.WriteLine($"({X4}, {Y4})({X3}, {Y3})");
                }
            }
        }
       static double Closer(double X,double Y)
        {
          double distance = Math.Abs(X) + Math.Abs(Y);
            return distance;
        }
        static double Distance(double x1,double y1,double x2,double y2)
        {
           double distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            return distance;
        }
    }
}

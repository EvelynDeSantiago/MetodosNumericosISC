using System;

namespace MetodosNumericosISC
{
    class Ejemplo1
    {
        static void Main(string[] args)
        {
            Func<double, double> function = x => x * x - 4;

            double a = 0;
            double b = 3;
            double epsilon = 0.0001;

            double root = Biseccion(function, a, b, epsilon);

            Console.WriteLine("La raiz aproximada es: " + root);
        }

        static double Biseccion(Func<double, double> function, double a, double b, double epsilon)
        {
            if (function(a) * function(b) > 0)
            {
                throw new ArgumentException("La funcion no cambia de signo en el intervalo dado.");
            }

            while ((b - a) >= epsilon)
            {
                double c = (a + b) / 2;
                double fc = function(c);

                if (Math.Abs(fc) < epsilon)
                    return c;

                if (fc * function(a) < 0)
                    b = c;
                else
                    a = c;
            }

            return (a + b) / 2;
        }
    }
}


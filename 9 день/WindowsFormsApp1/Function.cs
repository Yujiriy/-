using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Series<T> where T : Function
    {
        private T[] functions;

        public Series(T[] functions)
        {
            this.functions = functions;
        }

        public string CalculateAndDisplayResults(double x)
        {
            StringBuilder sb = new StringBuilder();
            foreach (T function in functions)
            {
                double result = function.Calculate(x);
                string display = function.DisplayResult();
                sb.AppendLine(display);
            }
            return sb.ToString();
        }
    }
    abstract class Function
    {
        public virtual double Calculate(double x)
        {
            throw new NotImplementedException();
        }

        public virtual string DisplayResult()
        {
            throw new NotImplementedException();
        }
    }

    class Ellipse : Function
    {
        private double result;

        public override double Calculate(double x)
        {
            result = Math.Sqrt(1 - Math.Pow(x, 2));
            return result;
        }

        public override string DisplayResult()
        {
            return "Значение функции для эллипса: " + result;
        }
    }

    class Hyperbola : Function
    {
        private double result;

        public override double Calculate(double x)
        {
            result = (x == 0 ? double.PositiveInfinity : 1 / x);
            return result;
        }

        public override string DisplayResult()
        {
            return "Значение функции для гиперболы: " + result;
        }
    }

    class Parabola : Function
    {
        private double result;

        public override double Calculate(double x)
        {
            result = Math.Pow(x, 2);
            return result; 
        }

        public override string DisplayResult()
        {
            return "Значение функции для параболы: " + result;
        }
    }

}

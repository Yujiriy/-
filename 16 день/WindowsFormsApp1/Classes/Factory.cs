using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class ShapeFactory
    {
        private Random random;

        public ShapeFactory()
        {
            random = new Random();
        }

        public IFigure CreateShape()
        {
            int randomNumber = random.Next(1, 5); // Генерация случайного числа от 1 до 4

            switch (randomNumber)
            {
                case 1:
                    return new SquareFigure();
                case 2:
                    return new LineFigure();
                case 3:
                    return new TFigure();
                case 4:
                    return new SuperFigure();
                default:
                    throw new InvalidOperationException("Неизвестный тип фигуры");
            }
        }
    }
}

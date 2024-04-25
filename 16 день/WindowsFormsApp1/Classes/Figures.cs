using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    

   
        public interface IFigure
        {
            void Draw();
            void Rotate();
            
            int CellCount { get; }
        }

        public class SquareFigure : IFigure
        {
            public int CellCount { get; } = 4;

            public void Draw()
            {
                
            }

            public void Rotate()
            {
                
            }

           
        }

        public class LineFigure : IFigure
        {
            public int CellCount { get; } = 3;

            public void Draw()
            {
                
            }

            public void Rotate()
            {
                
            }

            
        }

        public class TFigure : IFigure
        {
            public int CellCount { get; } = 5;

            public void Draw()
            {
                
            }

            public void Rotate()
            {
               
            }

            
        }

        public class SuperFigure : IFigure
        {
            public int CellCount { get; } = 8;

            public void Draw()
            {
               

            }

            public void Rotate()
            {
                
            }

           
        }
    

}

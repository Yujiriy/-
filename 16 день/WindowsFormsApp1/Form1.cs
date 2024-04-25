using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ShapeFactory shapeFactory;
        public List<IFigure> figureList;
        public Form1()
        {
            InitializeComponent();
            shapeFactory = new ShapeFactory();
            figureList = new List<IFigure>();
        }

        private void btnCreateShape_Click(object sender, EventArgs e)
        {
            IFigure shape = shapeFactory.CreateShape();
            shape.Draw();

            string shapeInfo = $"Создана фигура типа: {shape.GetType().Name}, размера {shape.CellCount}";
            listBox1.Items.Add(shapeInfo);
            figureList.Add(shape);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1) // Check if an item is selected in the listbox
            {
                int selectedIndex = listBox1.SelectedIndex;
                IFigure selectedShape = figureList[selectedIndex];

                // Rotate the selected shape
                selectedShape.Rotate();

                // Update the listbox item with the new information
                string updatedShapeInfo = $"Фигура {selectedShape.GetType().Name} повернута, размер {selectedShape.CellCount}";
                listBox1.Items[selectedIndex] = updatedShapeInfo;
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите фигуру из списка.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            figureList.Clear();
        }
    }
}

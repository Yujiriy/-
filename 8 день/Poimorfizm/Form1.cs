using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poimorfizm
{
    public partial class Form1 : Form
    {
        private List<IBuilding> buildings;
        private List<MusicalInstrument> orchestra;
        public Form1()
        {
            InitializeComponent();
            buildings = new List<IBuilding>();
            orchestra = new List<MusicalInstrument>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void DisplayBuildingInformation()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IBuilding building in buildings)
            {
                sb.AppendLine(building.DisplayInformation());
                sb.AppendLine();
            }
            MessageBox.Show(sb.ToString(), "Building Information");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string buildingType = buildingTypeComboBox.SelectedItem as string;
            if (buildingType == "Театр")
            {
                Theater theater = new Theater();
                theater.Address = addressTextBox.Text;
                theater.YearBuilt = int.Parse(yearBuiltTextBox.Text);
                theater.Name = nameTextBox.Text;
                buildings.Add(theater);
                
            }
            else if (buildingType == "Музей")
            {
                Museum museum = new Museum();
                museum.Address = addressTextBox.Text;
                museum.YearBuilt = int.Parse(yearBuiltTextBox.Text);
                museum.Name = nameTextBox.Text;
                buildings.Add(museum);
               
            }

            addressTextBox.Clear();
            yearBuiltTextBox.Clear();
            nameTextBox.Clear();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DisplayBuildingInformation();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            string instType = comboBox1.SelectedItem as string;
            if (instType == "Струнный")
            {
                // Пример добавления струнного инструмента
                string name = textBoxName.Text; // Предполагается, что есть TextBox для имени
                int numberOfStrings;
                if (!int.TryParse(textBoxStrings.Text, out numberOfStrings)) // Предполагается, что есть TextBox для количества струн
                {
                    MessageBox.Show("Введите корректное количество струн.");
                    return;
                }

                Stringed stringedInstrument = new Stringed(name, numberOfStrings);
                orchestra.Add(stringedInstrument);
                listBoxOrchestra.Items.Add($"Струнный: {name}, Струны: {numberOfStrings}");
            }
            else if (instType == "Духовой")
            {
                // Пример добавления духового инструмента
                string name = textBoxName.Text; // Предполагается, что есть TextBox для имени
                string windType = label7.Text; // Предполагается, что есть TextBox для типа духового инструмента

                Wind windInstrument = new Wind(name, windType);
                orchestra.Add(windInstrument);
                listBoxOrchestra.Items.Add($"Духовой: {name}, Тип: {windType}");
            }
            else if (instType == "Ударный")
            {
                // Пример добавления ударного инструмента
                string name = textBoxName.Text; // Предполагается, что есть TextBox для имени
                string drumType = textBoxDrumType.Text; // Предполагается, что есть TextBox для типа ударного инструмента

                Percussion percussionInstrument = new Percussion(name, drumType);
                orchestra.Add(percussionInstrument);
                listBoxOrchestra.Items.Add($"Ударный: {name}, Тип барабана: {drumType}");
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            listBoxOrchestra.Items.Clear();
            foreach (var instrument in orchestra)
            {
                instrument.Play(listBoxOrchestra);
            }
        }
    }


}

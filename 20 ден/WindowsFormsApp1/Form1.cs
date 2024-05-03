using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{

    
    public partial class Form1 : Form
    {
        List<Apartment> aparts = new List<Apartment>();
        List<Room> rooms = new List<Room>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AreaRoomTrackBar_Scroll(object sender, EventArgs e)
        {
            linkLabel2.Text = AreaRoomTrackBar.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {   Apartment app = CreateApartment();
            aparts.Add(app);
            richTextBox1.AppendText(app.ToString());
        }

        private Apartment CreateApartment()
        {
            
            double area = (double)AreaNumericUpDown.Value;
            int numberOfRooms = (int)numberOfRoomsnumericUpDown.Value;

            string country = countryTextBox1.Text;
            string city = cityTextBox1.Text;
            string street = streetTextBox1.Text;
            string building = buildingMaterialComboBox.Text;
            string appartmentnumber = apartmentNumberTextBox1.Text;
            string district = districtTextBox1.Text;
            string unit = unitTextBox1.Text;

            return new Apartment
            {
                Area = area,
                NumberOfRooms = numberOfRooms,
                Address = new Address
                {
                    Country = country,
                    City = city,
                    Street = street,
                    Building = building,
                    ApartmentNumber = appartmentnumber,
                    District = district,
                    Unit = unit
                },
                Rooms = rooms
            };
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rooms.Add(new Room {
                Area = AreaRoomTrackBar.Value,
                NumberOfWindows = (int)numberOfWindowsNumericUpDown.Value,
                WindowOrientation = windowOrientationTextBox.Text,
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(aparts);
            

            // Сохранение JSON в файл
            string filePath = "apartments.json"; 
            File.WriteAllText(filePath, json);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = "apartments.json"; 

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                aparts = JsonConvert.DeserializeObject<List<Apartment>>(json);
                
                foreach ( Apartment part in aparts ) {
                    richTextBox1.AppendText(part.ToString());
                }
            }
        }
    }
}

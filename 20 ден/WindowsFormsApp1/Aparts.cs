using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Apartment
    {
        public double Area { get; set; }
        public int NumberOfRooms { get; set; }
        public List<string> Options { get; set; }
        public int YearBuilt { get; set; }
        public string BuildingMaterial { get; set; }
        public int Floor { get; set; }

        public List<Room> Rooms { get; set; }

        public Address Address { get; set; }

        public Apartment()
        {
            Options = new List<string>();
        }

        public double CalculatePrice(double basePricePerSquareMeter, double additionalPricePerRoom)
        {
            double totalArea = Area;
            double totalPrice = basePricePerSquareMeter * totalArea;

            int totalRooms = NumberOfRooms + Rooms.Count;
            totalPrice += additionalPricePerRoom * totalRooms;

            return totalPrice;
        }
        public override string ToString()
        {
            string roomInfo = string.Join("\n", Rooms.Select(room => room.ToString()));

            return $"Area: {Area}\n" +
                   $"Number of Rooms: {NumberOfRooms}\n" +
                   $"Year Built: {YearBuilt}\n" +
                   $"Building Material: {BuildingMaterial}\n" +
                   $"Floor: {Floor}\n" +
                   $"Address: {Address}\n" +
                   $"Rooms:\n{roomInfo}";
        }
    }

    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Unit { get; set; }
        public string ApartmentNumber { get; set; }

        public override string ToString()
        {
            return $"{Country}, {City}, {District}, {Street}, {Building}, {Unit}, {ApartmentNumber}";
        }
    }

    public class Room
    {
        public double Area { get; set; }
        public int NumberOfWindows { get; set; }
        public string WindowOrientation { get; set; }

        public override string ToString()
        {
            return $"Area: {Area}\n" +
                $"Number of Windows: {NumberOfWindows}\n" +
                $"Window Orientation: {WindowOrientation}";
        }
    }
}

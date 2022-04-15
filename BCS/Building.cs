using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS
{
    public class Building
    {
        private string name;
        private string city;
        private int stars;
        private double rentAmount;
        private bool isAvailable;

        public Building(string name, string city, int stars, double rentAmount)
        {
            this.Name = name;
            this.City = city;
            this.Stars = stars;
            this.RentAmount = rentAmount;
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public string City
        {
            get { return city; }
            private set { city = value; }
        }
        public int Stars
        {
            get { return stars; }
            private set { stars = value; }
        }
        public double RentAmount
        {
            get { return rentAmount; }
            private set { rentAmount = value; }
        }
        public bool IsAvailable
        {
            get { return isAvailable; }
            private set { isAvailable = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Building: {Name} <{Stars}>");
            sb.AppendLine($"****Location: {City}");
            sb.AppendLine($"****RentAmount: {RentAmount}");
            sb.AppendLine($"****Is Available: {IsAvailable}");
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS
{
    public abstract class Building
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
            this.isAvailable = true;
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("building name", "Building name must not be null or empty!");
                }
                if (!value.EndsWith(this.GetType().Name))
                {
                    throw new ArgumentException($"Name of {this.GetType().Name.ToLower()} buildings should end on {this.GetType().Name}!");
                }
                name = value;
            }
        }
        public string City
        {
            get { return city; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("building city", "City must not be null or empty!");
                }
                city = value;
            }
        }
        public int Stars
        {
            get { return stars; }
            private set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("building stars", "Stars cannot be less than 0 or above 5!");
                }
                stars = value;
            }
        }
        public double RentAmount
        {
            get { return rentAmount; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("rent amount", "Rent amount cannot be less or equal to 0!");
                }
                rentAmount = value;
            }
        }
        public bool IsAvailable
        {
            get { return isAvailable; }
        }

        public void RentBuilding()
        {
            this.isAvailable = false;
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

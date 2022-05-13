using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS
{
    public class Broker
    {
        private string name;
        private int age;
        private string city;
        private double bonus;
        private List<Building> buildings;

        public Broker(string name, int age, string city)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
            this.buildings = new List<Building>();
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("broker name", "Broker name must not be null or empty!");
                }
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 16 || value > 70)
                {
                    throw new ArgumentOutOfRangeException("broker age", "Broker's age cannot be less than 16 or above 70!");
                }
                age = value;
            }
        }
        public string City
        {
            get { return city; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("broker city", "City must not be null or empty!");
                }
                city = value;
            }
        }
        public double Bonus
        {
            get { return bonus; }
        }

        public double ReceiveBonus(Building building)
        {
            double currentBonus = building.RentAmount * 2 * building.Stars / 100;
            this.bonus += currentBonus;
            building.RentBuilding();
            this.buildings.Add(building);

            return currentBonus;
        }
    }
}

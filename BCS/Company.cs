using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS
{
    public class Company
    {
        private string name;
        private List<Building> buildings;
        private List<Broker> brokers;

        public Company(string name)
        {
            this.Name = name;
            this.buildings = new List<Building>();
            this.brokers = new List<Broker>();
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public void AddBroker(Broker broker)
        {
            if(GetBrokerByName(broker.Name) == null)
            {
                this.brokers.Add(broker);
            }
        }

        public void AddBuilding(Building building)
        {
            if(this.GetBuildingByName(building.Name) == null)
            {
                this.buildings.Add(building);
            }
        }
        public Broker GetBrokerByName(string name)
        {
            return this.brokers.Where(b => b.Name.Equals(name)).FirstOrDefault();
        }

        public Building GetBuildingByName(string name)
        {
            return this.buildings.Where(b => b.Name.Equals(name)).FirstOrDefault();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Company: {Name}");
            sb.AppendLine($"##Brokers: {this.brokers.Count}");
            foreach (var broker in this.brokers)
            {
                sb.Append(broker);
            }

            sb.AppendLine($"##Buildings – {buildings.Count}");
            foreach (var building in this.buildings)
            {
                sb.Append(building);
            }

            return sb.ToString();
        }
    }
}

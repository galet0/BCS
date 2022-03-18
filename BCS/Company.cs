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

    }
}

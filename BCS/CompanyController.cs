using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS
{
    public class CompanyController
    {
        private List<Company> companies;

        public CompanyController()
        {
            this.companies = new List<Company>();
        }
        public string CreateCompany(List<string> args)
        {
            Company company = new Company(args[0]);
            companies.Add(company);

            return "";
        }

        public string RegisterBuilding(List<string> args)
        {
            //Residence*Hell Residence*Plovdiv*2*20000*Deager
            Building building = null;

            switch (args[0])
            {
                case "Business":
                    building = new Business(args[1], args[2], int.Parse(args[3]), double.Parse(args[4]));
                    break;
                case "Hotel":
                    building = new Hotel(args[1], args[2], int.Parse(args[3]), double.Parse(args[4]));
                    break;
                case "Residence":
                    building = new Residence(args[1], args[2], int.Parse(args[3]), double.Parse(args[4]));
                    break;
            }

            Company company = this.GetCompanyByName(args[5]);
            if(company != null)
            {
                company.AddBuilding(building);
            }

            return "";
        }

        public string RegisterBroker(List<string> args)
        {
            //Sade*35*Plovdiv*Deager
            Broker broker = new Broker(args[0], int.Parse(args[1]), args[2]);
            Company company = this.GetCompanyByName(args[3]);
            if (company != null)
            {
                company.AddBroker(broker);
            }

            return "";
        }

        public string RentBuilding(List<string> args)
        {
            Company company = this.GetCompanyByName(args[0]);
            Building building = company.GetBuildingByName(args[1]);
            Broker broker = company.GetBrokerByName(args[2]);
            double bonus = broker.ReceiveBonus(building);

            return "";
        }

        public string CompanyInfo(List<string> args)
        {
            Company company = this.GetCompanyByName(args[0]);
            if(company != null)
            {
                return company.ToString();
            }

            return "";
        }

        public string Shutdown()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Companies: {companies.Count}");
            foreach (var company in this.companies)
            {
                sb.Append($"{CompanyInfo(new List<string>() { company.Name })}");
            }

            return sb.ToString();
        }

        private Company GetCompanyByName(string name)
        {
            return this.companies.Where(c => c.Name == name).FirstOrDefault();
        }
    }
}

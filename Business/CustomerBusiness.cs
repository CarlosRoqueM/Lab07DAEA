using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CustomerBusiness
    {

        public List<Customers> GetCostumers(string name)
        {
            List<Customers> costumer = new List<Customers>();
            CustomersData data = new CustomersData();
            costumer = data.GetCustomers();

            
            return costumer;
        }

        public List<Customers> GetCostumersByName(string name)
        {
            List<Customers> costumer = new List<Customers>();
            CustomersData data = new CustomersData();
            costumer = data.GetCustomers();

            var result = costumer.Where(c => c.name.Contains(name)).ToList();

            return result;
        }
    }
}

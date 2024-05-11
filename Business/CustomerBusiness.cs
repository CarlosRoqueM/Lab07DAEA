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
        private CustomersData data;
        public CustomerBusiness()
        {
            CustomersData data= new CustomersData();
        }

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

        public void InsertCostumer()
        {
            CustomersData data = new CustomersData();
            data.InsertCustomers();
        }

        public void DeleteCustomer(int id)
        {
         
            data.DeleteCustomer(id);
        }

    }
}

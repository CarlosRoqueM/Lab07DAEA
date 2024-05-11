using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Data
{
    public class CustomersData
    {
        public List<Customers> GetCustomers()
        {
            string ConnectionString = "Data Source= LAB1504-04\\SQLEXPRESS; Initial Catalog=lab07;" + "User Id = Carlos; Password=123456";

            List<Customers> customers = new List<Customers>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("ListCustomers", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int customer_id = reader.GetInt32("customer_id");
                    string name = reader.GetString("name");
                    string address = reader.GetString("address");
                    string phone = reader.GetString("phone");
                    bool active = reader.GetBoolean("active");


                    customers.Add(new Customers { costumer_id = customer_id, name = name, address = address, phone = phone, active = active  });

                }
                connection.Close();
                return customers;

            }
        }

        public List<Customers> GetCustomers2()
        {
            string ConnectionString = "Data Source= LAB1504-04\\SQLEXPRESS; Initial Catalog=lab07;" + "User Id = Carlos; Password=123456";

            List<Customers> customers = new List<Customers>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("ListCustomers", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int customer_id = reader.GetInt32("customer_id");
                    string name = reader.GetString("name");
                    string address = reader.GetString("address");
                    string phone = reader.GetString("phone");
                    bool active = reader.GetBoolean("active");


                    customers.Add(new Customers { costumer_id = customer_id, name = name, address = address, phone = phone, active = active });

                }
                connection.Close();
                return customers;

            }
        }
        // Insertar customers

        public void InsertCustomers()
        {
            string ConnectionString = "Data Source= LAB1504-04\\SQLEXPRESS; Initial Catalog=lab07;" + "User Id = Carlos; Password=123456";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("InsertCustomers2", connection);
                command.CommandType = CommandType.StoredProcedure;

               

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        //eliminar customers

        public void DeleteCustomer(int id)
        {
            string ConnectionString = "Data Source= LAB1504-04\\SQLEXPRESS; Initial Catalog=lab07;" + "User Id = Carlos; Password=123456";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DeleteCustomer2", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@customer_id", id);

                ///int rowsAffected = command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}

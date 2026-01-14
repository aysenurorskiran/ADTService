using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ADTServis.DAL.Db;
using ADTServis.Entities;

namespace ADTServis.DAL.Repositories
{
    public class CustomerRepository
    {

        public void Add(Customer c)
        {
            MySqlConnection conn = DbConnectionFactory.Create();
            conn.Open();
            string insertsql = "INSERT INTO Customers(FullName,Phone,Plate,CarBrand,CarModel)" + "VALUES (@FullName,@Phone,@Plate,@CarBrand,@CarModel)";
            MySqlCommand cmd = new MySqlCommand(insertsql, conn);

            cmd.Parameters.AddWithValue("@FullName", c.FullName);
            cmd.Parameters.AddWithValue("@Phone", c.Phone);
            cmd.Parameters.AddWithValue("@Plate", c.Plate);
            cmd.Parameters.AddWithValue("@CarBrand", c.CarBrand);
            cmd.Parameters.AddWithValue("@CarModel", c.CarModel);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Customer> GetAll()
        {
            List<Customer> list = new List<Customer>();
            MySqlConnection conn = DbConnectionFactory.Create();
            conn.Open();

            string selectSql = "SELECT Id,FullName,Phone,Plate,CarBrand,CarModel FROM Customers";
            MySqlCommand cmd = new MySqlCommand(selectSql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer c = new Customer();

                c.Id = reader.GetInt32("Id");
                c.FullName = reader.GetString("FullName");
                c.Plate = reader.GetString("Plate");
                if (reader.IsDBNull(reader.GetOrdinal("Phone")))
                {
                    c.Phone = null;
                }
                else
                {
                    c.Phone = reader.GetString("Phone");
                }
                if (reader.IsDBNull(reader.GetOrdinal("CarBrand")))
                {
                    c.CarBrand = null;
                }
                else
                {
                    c.CarBrand = reader.GetString("CarBrand");
                }
                if (reader.IsDBNull(reader.GetOrdinal("CarModel")))
                {
                    c.CarModel = null;
                }
                else
                {
                    c.CarModel = reader.GetString("CarModel");
                }
                list.Add(c);
            }
            conn.Close();
            return list;
        }
    }
}


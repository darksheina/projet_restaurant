using System;
using System.Data.SqlClient;

namespace RestaurationModel
{
    public class RestaurantModel
    {
        public void Main()
        {
            string connectionString;
            SqlConnection cnn;
            cnn = new SqlConnection();
            cnn.Open();
            Console.WriteLine("connection Open!");
            cnn.Close();
        }

        private Scenario scenario;

    }
}


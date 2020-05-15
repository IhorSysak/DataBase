using LinqToDB;
using System;
using System.Configuration;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using LinqToDB.SqlQuery;

namespace ADO.NET_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Console.WriteLine(connectionString);

            string outputTable = "SELECT *FROM Farm";

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();

                SqlCommand command_output = new SqlCommand(outputTable, connection);
                SqlDataReader reader = command_output.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    while (reader.Read())
                    {
                        object id = reader["id"];
                        object Name_farm = reader["Name_farm"];
                        object Number_of_cattle = reader["Number_of_cattle"];

                        Console.WriteLine("{0} \t{1} \t{2}", id, Name_farm, Number_of_cattle);
                    }
                }

                Console.WriteLine();
                reader.Close();
            }

            /*Console.WriteLine("Enter id: ");
            int new_id = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter name: ");
            string new_name = Console.ReadLine();

            Console.WriteLine("Enter number: ");
            int new_number_of_cattle = Int32.Parse(Console.ReadLine());

            string sql_Insert_Update = String.Format("INSERT INTO Farm (id, Name_farm, Number_of_cattle) VALUES ('{0}', '{1}', '{2}')", new_id, new_name, new_number_of_cattle);

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();
                Console.WriteLine("Open connection");

                SqlCommand command = new SqlCommand(sql_Insert_Update, connection);  // Insert and Update
                int number = command.ExecuteNonQuery();

                Console.WriteLine("Enter a new name: ");
                new_name = Console.ReadLine();
                sql_Insert_Update = String.Format("UPDATE Farm SET Name_farm='{0}' WHERE id ={1}", new_name, new_id);
                command.CommandText = sql_Insert_Update;
                number = command.ExecuteNonQuery();

                Console.WriteLine("Update: {0}", number);
                Console.WriteLine();
            }*/

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command_output = new SqlCommand(outputTable, connection);
                SqlDataReader reader = command_output.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    while (reader.Read())
                    {
                        object id = reader["id"];
                        object Name_farm = reader["Name_farm"];
                        object Number_of_cattle = reader["Number_of_cattle"];

                        Console.WriteLine("{0} \t{1} \t{2}", id, Name_farm, Number_of_cattle);
                    }
                }

                reader.Close();
            }

            /*string sqlCount = "SELECT COUNT(*) FROM Growing_crops";
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCount, connection);
                object count = command.ExecuteScalar();

                command.CommandText = "SELECT MIN(Area) FROM Growing_crops";
                object minArea = command.ExecuteScalar();

                Console.WriteLine("In table {0} objects", count);
                Console.WriteLine("Min Area: {0}", minArea);
            }*/

            /*using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "INSERT INTO Growing_crops (id, Name_crops, Area) VALUES(3, 'Apple', 180)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO Growing_crops (id, Name_crops, Area) VALUES(3, 'Apple', 180)";
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    Console.WriteLine("Commit successful");
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                }
            }*/

            DataContext db = new DataContext(connectionString);

            
            var query = db.GetTable<Type_of_Products>().Where(u => u.Price > 25).OrderBy(u => u.Name_products);

            foreach (var products in query)
            {
                Console.WriteLine("{0} \t{1} \t{2}", products.Id, products.Name_products, products.Count, products.Price);
            }

            Console.Read();
        }
    }
}

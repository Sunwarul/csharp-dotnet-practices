using System;
using System.Threading.Tasks;
using MySqlConnector;

namespace CSharpProgramming
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            string connectionString = "server=localhost;user=root;password=;database=spa;";

            using var connection = new MySqlConnection(connectionString);

            await connection.OpenAsync();

            using var command = new MySqlCommand("SELECT id, name, price FROM products;", connection);
            using (var reader = command.ExecuteReader())
            {
                Console.WriteLine("Id\tPrice\tName");
                Console.WriteLine("---------------------------------");
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetValue(0) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(1));
                }
            }

        }
    }
}


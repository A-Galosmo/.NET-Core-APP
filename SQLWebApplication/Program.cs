using System;
using Microsoft.Data.SqlClient;



static void Main()
{
    string connectionString = "Server=testonly.database.windows.net;Database=myTestDB;User Id=akoonly;Password=Number@123!;";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();

        // Perform a sample query 
        string query = "select * from [dbo].[Records]"; // Testing sample queries
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Process the data returned by the query
                    string columnName = reader.GetString(0);  // Replace 0 with the appropriate column index
                    Console.WriteLine(columnName);
                }
            }
        }
    }

    Console.ReadLine();
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class Startup
{
    public static void Main()
    {
        var builder = new SqlConnectionStringBuilder
        {
            ["Data Source"] = ".",
            ["Integrated Security"] = true,
            ["initial catalog"] = "MinionsDB"
        };

        var resultLines = new List<string>();

        var connection = new SqlConnection(builder.ToString());
        connection.Open();

        using (connection)
        {
            try
            {
                var villainWithMinionsCount = "SELECT V.Name, COUNT(MinionId) AS [MinionCount] FROM MinionsVillains AS ref "+
                    "JOIN Villains AS v ON v.Id = ref.VillainId "+
                    "JOIN Minions AS m ON m.Id = ref.MinionId "+
                    "GROUP BY VillainId, V.Name "+
                    "HAVING COUNT(MinionId) > 3 "+
                    "ORDER BY COUNT(MinionId) DESC";

                var command = new SqlCommand(villainWithMinionsCount, connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    resultLines.Add($"{reader[0]} - {reader[1]}");
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        resultLines.ForEach(x => Console.WriteLine(x));
    }
}

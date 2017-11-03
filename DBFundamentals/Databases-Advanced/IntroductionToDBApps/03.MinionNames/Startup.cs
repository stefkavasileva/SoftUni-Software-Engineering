using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

public class Startup
{
    public static void Main()
    {
        var sb = new StringBuilder();

        var builder = new SqlConnectionStringBuilder
        {
            ["Data Source"] = ".",
            ["Integrated Security"] = true,
            ["initial catalog"] = "MinionsDB"
        };

        var connection = new SqlConnection(builder.ToString());
        connection.Open();

        using (connection)
        {
            try
            {
                var villainNameSql = "SELECT Name FROM Villains " +
                                     "WHERE Id = @villainId";
                var command = new SqlCommand(villainNameSql, connection);

                var villainId = int.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@villainId", villainId);

                SqlDataReader reader = command.ExecuteReader();
                var villainName = reader.Read() ? reader[0] : null;

                if (villainName is null)
                {
                    reader.Close();
                    throw new ArgumentException($"No villain with ID {villainId} exists in the database.");
                }

                reader.Close();

                sb.AppendLine($"Villain: {Convert.ToString(villainName)}");

                var minionsSql = "SELECT Name, Age FROM Minions " +
                                 "WHERE Id IN(SELECT MinionId FROM MinionsVillains " +
                                 "WHERE VillainId = @villainId) " +
                                 "ORDER BY Name";

                command = new SqlCommand(minionsSql, connection);
                command.Parameters.AddWithValue("@villainId", villainId);

                var counter = 1;
                var minions = new List<string>();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    minions.Add($"{counter}. {reader[0]} {reader[1]}");
                    counter++;
                }

                reader.Close();

                if (minions.Any())
                {
                    minions.ForEach(x => sb.AppendLine(x));
                }
                else
                {
                    sb.Append("(no minions)");
                }


                Console.WriteLine(sb.ToString().Trim());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
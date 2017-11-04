using System;
using System.Data.SqlClient;

public class Startup
{
    public static void Main()
    {
        var minionArgs = Console.ReadLine().Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        var minionName = minionArgs[1];
        var minionTown = minionArgs[3];

        var villainArgs = Console.ReadLine().Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        var villainName = villainArgs[1];

        var builder = new SqlConnectionStringBuilder
        {
            ["Data Source"] = "DESKTOP-P3EEUC7\\SQLEXPRESS",
            ["Integrated Security"] = true,
            ["initial catalog"] = "MinionsDB"
        };

        var connection = new SqlConnection(builder.ToString());
        connection.Open();

        using (connection)
        {
            var townNameSql = "SELECT Name FROM Towns " +
                              "WHERE Name = @townName";
            var command = new SqlCommand(townNameSql, connection);
            command.Parameters.AddWithValue("@townName", minionTown);
            var reader = command.ExecuteReader();

            if (!reader.Read())
            {               
                reader.Close();;
                // add town to databasere
                var insertTownSql = "INSERT INTO Towns(Name) VALUES (@townName)";
               command = new SqlCommand(insertTownSql, connection);
                command.Parameters.AddWithValue("@townName", minionTown);
                command.ExecuteNonQuery();
                Console.WriteLine($"Town {minionTown} was added to the database.");
            }

            reader.Close();
            var villainSql = "SELECT Name FROM Villains " +
                             "WHERE Name = @villainName";

            command = new SqlCommand(villainSql, connection);
            command.Parameters.AddWithValue("@villainName", villainName);
            reader = command.ExecuteReader();

            if (!reader.Read())
            {              
                reader.Close();
                // add villain to batabase
                var insertVillainSql =
                    "INSERT INTO Villains(Name,EvilnessFactorId) VALUES (@villainName,@evilnessFactorId)";
                command = new SqlCommand(insertVillainSql, connection);
                command.Parameters.AddWithValue("@villainName", minionTown);
                command.Parameters.AddWithValue("@evilnessFactorId)", 4);
                command.ExecuteNonQuery();
                Console.WriteLine($"Villain {villainName} was added to the database.");
            }
            reader.Close();

            //Take ids of minion and villains
            var minionIdSql = "SELECT Id FROM Minions WHERE Name = @minionName";
            command = new SqlCommand(minionIdSql,connection);
            command.Parameters.AddWithValue("@minionName", minionName);
            reader = command.ExecuteReader();
            var minionId = -1;
            while (reader.Read())
            {
                minionId = Convert.ToInt32(reader[0]);
            }

            reader.Close();

            var villainIdSql = "SELECT Id FROM Villains WHERE Name = @villainName";
            command = new SqlCommand(villainIdSql, connection);
            command.Parameters.AddWithValue("@villainName", villainName);
            reader = command.ExecuteReader();
         
            var villainId = -1;
            while (reader.Read())
            {
                villainId = Convert.ToInt32(reader[0]);
            }

            reader.Close();

            var insertMinionToVillainSql =
                "INSERT INTO MinionsVillains (MinionId,VillainId) VALUES (@minionId,@villainId)";
            command= new SqlCommand(insertMinionToVillainSql,connection);
            command.Parameters.AddWithValue("@minionId", minionId);
            command.Parameters.AddWithValue("@villainId", villainId);
            command.ExecuteNonQuery();
            Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
        }
    }
}


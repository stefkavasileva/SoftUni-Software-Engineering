using System;
using System.Data.SqlClient;

public class StartUp
{
    static void Main()
    {
        var builder = new SqlConnectionStringBuilder
        {
            ["Data Source"] = ".",
            ["Integrated Security"] = true
        };

        var connection = new SqlConnection(builder.ToString());
        connection.Open();

        using (connection)
        {
            try
            {
                var cmd = new SqlCommand("CREATE DATABASE MinionsDB", connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        builder["initial catalog"] = "MinionsDB";
        connection = new SqlConnection(builder.ToString());

        connection.Open();
        using (connection)
        {
            try
            {
                var createCountriesSQL = "CREATE TABLE Countries (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50))";
                var createTownsSQL = "CREATE TABLE Towns (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), CountryId INT, CONSTRAINT FK_TownCountry FOREIGN KEY (CountryId) REFERENCES Countries(Id))";
                var createMinionsSQL = "CREATE TABLE Minions (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), Age INT, TownId INT, CONSTRAINT FK_Towns FOREIGN KEY (TownId) REFERENCES Towns(Id))";
                var createEvilnessFactorsSQL = "CREATE TABLE EvilnessFactors (Id INT PRIMARY KEY, Name VARCHAR(10) UNIQUE NOT NULL)";
                var createVillainsSQL = "CREATE TABLE Villains (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), EvilnessFactorId INT, CONSTRAINT FK_VillainEvilnessFactor FOREIGN KEY (EvilnessFactorId) REFERENCES EvilnessFactors(Id))";
                var createMinionsVillainsSQL = "CREATE TABLE MinionsVillains(MinionId INT, VillainId INT, CONSTRAINT FK_Minions FOREIGN KEY (MinionId) REFERENCES Minions(Id), CONSTRAINT  FK_Villains FOREIGN KEY (VillainId) REFERENCES Villains(Id), CONSTRAINT PK_MinionsVillains PRIMARY KEY(MinionId, VillainId))";

                ExecuteCommand(createCountriesSQL, connection);
                ExecuteCommand(createTownsSQL, connection);
                ExecuteCommand(createMinionsSQL, connection);
                ExecuteCommand(createEvilnessFactorsSQL, connection);
                ExecuteCommand(createVillainsSQL, connection);
                ExecuteCommand(createMinionsVillainsSQL, connection);

                var insertCountriesSQL = "INSERT INTO Countries VALUES ('Bulgaria'), ('United Kingdom'), ('United States of America'), ('France')";
                var insertTownsSQL = "INSERT INTO Towns (Name, CountryId) VALUES ('Sofia',1), ('Burgas',1), ('Varna', 1), ('London', 2),('Liverpool', 2),('Ocean City', 3),('Paris', 4)";
                var insertMinionsSQL = "INSERT INTO Minions (Name, Age, TownId) VALUES ('bob',10,1),('kevin',12,2),('stuart',9,3), ('rob',22,3), ('michael',5,2),('pep',3,2)";
                var insertEvilnessFactorsSQL = "INSERT INTO EvilnessFactors VALUES (1, 'Super Good'), (2, 'Good'), (3, 'Bad'), (4, 'Evil'), (5, 'Super Evil')";
                var insertVillainsSQL = "INSERT INTO Villains (Name, EvilnessFactorId) VALUES ('Gru', 2),('Victor', 4),('Simon Cat', 3),('Pusheen', 1),('Mammal', 5)";
                var insertMinionsVillainsSQL = "INSERT INTO MinionsVillains VALUES (1, 2), (3, 1), (1, 3), (3, 3), (4, 1), (2, 2), (1, 1), (3, 4), (1, 4), (1, 5), (5, 1)";

                ExecuteCommand(insertCountriesSQL, connection);
                ExecuteCommand(insertTownsSQL, connection);
                ExecuteCommand(insertMinionsSQL, connection);
                ExecuteCommand(insertEvilnessFactorsSQL, connection);
                ExecuteCommand(insertVillainsSQL, connection);
                ExecuteCommand(insertMinionsVillainsSQL, connection);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public static void ExecuteCommand(string commandText, SqlConnection connection)
    {
        var cmd = new SqlCommand(commandText, connection);
        cmd.ExecuteNonQuery();
    }
}

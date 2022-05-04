using Microsoft.Data.SqlClient;
using PokemonModels;
using System.Collections.Generic;
using System.Data;

namespace PokemonDL;

/*
 * in .net, "ADO.NET" is the branding for the Microsoft-provided data access technologies.
 * traditionally it was all under "System.Data" namespace somewhere. these days, we get those
 * assemblies via NuGet.
 */
/// <summary>
/// describe the classe
/// </summary>
/// <remarks>
/// more detailed explanations
/// </remarks>
public class SqlRepository : IRepository
{
    readonly string connectionString;

    /// <summary>
    /// summary
    /// </summary>
    public SqlRepository(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // specifically when SELECT statements and result sets are involved,
    // there are two approaches to writing the code.
    // this example uses "connected architecture"
    //    which involves - processing the result set while the connection is open
    //                   as you receive it row by row.

    //  in many practical applications, open connections to the database are
    //    a performance bottleneck. so we often prioritize keeping the connection
    //    open for the minimum possible time.

    // so the alternative is called "disconnected architecture"
    //    which involves using a DataAdapter to put the results in a DataSet
    //     then closing the connection
    //     then processing the data in the DataSet.

    // it's also possible to modify the DataSet and then treat those changes
    // as inserts, updates, and deletes to push to the database.
    public List<Pokemon> GetAllPokemonsConnected()
    {
        string commandString = "SELECT * FROM Pokemon;";

        // the connection (SqlConnection): represents a connection to a database.
        // needs a connection string to know how to connect and where the database is.
        // can Open and Close the connection. is IDisposable so you can have it automatically
        // close with the help of a using statement.
        using SqlConnection connection = new(connectionString);
        // the command (SqlCommand): encapsulates some SQL commands to send.
        //  it supports using SqlParameters for protecting from SQL injection.
        using IDbCommand command = new SqlCommand(commandString, connection);
        connection.Open();
        // the data reader (SqlDataReader): represents a response to a SqlCommand
        // having 1 or more result sets (because of 1 or more SELECT statements).
        // the data reader provides each row of the data immediately as it's
        // received over the network.
        using IDataReader reader = command.ExecuteReader();

        // TODO: leaving out the abilities for now
        var pokemons = new List<Pokemon>();
        // reader.Read advances the "cursor" to the next row
        // and returns true if it's not at the end of the data.
        while (reader.Read())
        {
            // different ways to access the data in the current row
            // - reader[columnName]
            //      the return type of this is object. probably need to cast the type.
            // - reader.Get_____(columnIndex)
            //      return type is whatever type you asked for
            // be aware of DBNull
            pokemons.Add(new Pokemon
            {
                Name = reader.GetString(0),
                Level = reader.GetInt32(2),
                Attack = reader.GetInt32(3),
                Defense = reader.GetInt32(4),
                Health = reader.GetInt32(5)
            });
        }
        return pokemons;
    }

    public List<Pokemon> GetAllPokemons()
    {
        string commandString = "SELECT * FROM Pokemon;";

        using SqlConnection connection = new(connectionString);
        using SqlCommand command = new(commandString, connection);
        IDataAdapter adapter = new SqlDataAdapter(command);
        DataSet dataSet = new();
        try
        {
            connection.Open();
            adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.}
        }
        catch (SqlException ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        finally
        {
            connection.Close();
        }

        // TODO: leaving out the abilities for now
        var pokemons = new List<Pokemon>();
        DataColumn levelColumn = dataSet.Tables[0].Columns[2];
        foreach (DataRow row in dataSet.Tables[0].Rows)
        {
            pokemons.Add(new Pokemon
            {
                Name = (string)row[0],
                Level = (int)row[levelColumn],
                Attack = (int)row["Attack"],
                Defense = (int)row[4],
                Health = (int)row[5]
            });
        }
        return pokemons;
    }

    public Pokemon AddPokemon(Pokemon poke)
    {
        string commandString = "INSERT INTO Pokemon (Name, Type, Level, Attack, Defense, Health) " +
            "VALUES (@name, @type, @level, @attack, @defense, @health);";

        using SqlConnection connection = new(connectionString);
        using SqlCommand command = new(commandString, connection);
        command.Parameters.AddWithValue("@name", poke.Name);
        command.Parameters.AddWithValue("@type", "Normal");
        command.Parameters.AddWithValue("@level", poke.Level);
        command.Parameters.AddWithValue("@attack", poke.Attack);
        command.Parameters.AddWithValue("@defense", poke.Defense);
        command.Parameters.AddWithValue("@health", poke.Health);
        connection.Open();
        command.ExecuteNonQuery();

        return poke;
    }

    /// <summary>
    /// asdfasdf
    /// </summary>
    /// <param name="poke">the pokemon model to add</param>
    /// <returns>the added pokemon</returns>
    public Pokemon AddPokemonUnsafe(Pokemon poke)
    {
        string commandString = "INSERT INTO Pokemon (Name, Type, Level, Attack, Defense, Health) " +
            $"VALUES ({poke.Name}, Normal, {poke.Level}, {poke.Attack}, {poke.Defense}, {poke.Health};";

        using SqlConnection connection = new(connectionString);
        using SqlCommand command = new(commandString, connection);
        //command.Parameters.AddWithValue("@name", poke.Name);
        //command.Parameters.AddWithValue("@type", "Normal");
        //command.Parameters.AddWithValue("@level", poke.Level);
        //command.Parameters.AddWithValue("@attack", poke.Attack);
        //command.Parameters.AddWithValue("@defense", poke.Defense);
        //command.Parameters.AddWithValue("@health", poke.Health);
        connection.Open();
        command.ExecuteNonQuery();

        return poke;
    }
}

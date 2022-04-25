using PokemonModels;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace PokemonDL
{
    public class SqlRepository : IRepository
    {
        private const string connectionStringFilePath = "../../../../PokemonDL/connection-string.txt";
        private readonly string connectionString;

        public SqlRepository()
        {
            connectionString = File.ReadAllText(connectionStringFilePath);
        }

        public List<Pokemon> GetAllPokemons()
        {
            string commandString = "SELECT FirstName FROM SalesLT.Customer";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var pokemons = new List<Pokemon>();
            while (reader.Read())
            {
                pokemons.Add(new Pokemon { Name = reader.GetString(0) });
            }
            return pokemons;
        }

        public Pokemon AddPokemon(Pokemon poke)
        {
            string commandString = "INSERT INTO SalesLT.Customer (FirstName) VALUES (@name)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@name", poke.Name);
            connection.Open();
            command.ExecuteNonQuery();

            return poke;
        }
    }
}

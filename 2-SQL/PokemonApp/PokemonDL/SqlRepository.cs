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
            string commandString = "SELECT * FROM Pokemon";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            // TODO: leaving out the abilities for now
            var pokemons = new List<Pokemon>();
            while (reader.Read())
            {
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

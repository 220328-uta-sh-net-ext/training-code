using PokemonModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace PokemonDL
{
    public class Repository : IRepository
    {
        private string filePath = "../PokemonDL/Database/";
        private string jsonString;
        public Pokemon AddPokemon(Pokemon poke)// Serialization
        {
            var pokemons = GetAllPokemons();
            pokemons.Add(poke);
            var pokemonString = JsonSerializer.Serialize<List<Pokemon>>(pokemons, new JsonSerializerOptions { WriteIndented = true });
            try
            {
                File.WriteAllText(filePath + "Pokemon.json", pokemonString);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Please check the path, " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check the file name, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return poke;
        }

        public List<Pokemon> GetAllPokemons()// Deserialization
        {
            try
            {
                jsonString = File.ReadAllText(filePath + "Pokemon.json");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Please check the path, " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check the file name, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (!string.IsNullOrEmpty(jsonString))
                return JsonSerializer.Deserialize<List<Pokemon>>(jsonString);
            else
                return null;
        }
    }
}
﻿using PokemonModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace PokemonDL;

public class Repository : IRepository
{
    readonly string filePath = "../../../../PokemonDL/Database/";
    string? jsonString;
    public Pokemon AddPokemon(Pokemon poke)// Serialization
    {
        List<Pokemon>? pokemons = GetAllPokemons();
        pokemons.Add(poke);
        string? pokemonString = JsonSerializer.Serialize<List<Pokemon>>(pokemons, new JsonSerializerOptions { WriteIndented = true });
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
            return JsonSerializer.Deserialize<List<Pokemon>>(jsonString)!;
        throw new InvalidDataException("json data missing or invalid");
    }

    public Task<List<Pokemon>> GetAllPokemonsAsync()
    {
        throw new NotImplementedException();
    }
}

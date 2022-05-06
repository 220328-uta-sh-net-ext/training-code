using ConsolePokemonApi;
using System.Net.Http;
using System.Net.Http.Headers;

using var client = new HttpClient();

client.BaseAddress = new Uri("http://localhost:5185/api/pokemon");
try{
var response=client.GetAsync("pokemon");
response.Wait();

var result = response.Result;

if(result.IsSuccessStatusCode){
    var readTask=result.Content.ReadAsAsync<List<Pokemon>>();
    readTask.Wait();

    var pokemons = readTask.Result;
    foreach (var p in pokemons)
    {
        Console.WriteLine(p.Name);
    }
    
}
}
catch(System.Net.Http.HttpRequestException ex){
    Console.WriteLine(ex.Message);
}
catch(Exception ex){
    Console.WriteLine(ex.Message);
}
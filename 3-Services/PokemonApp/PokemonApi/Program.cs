using PokemonBL;
using PokemonDL;


//"C:\Revature\220328-uta-sh-.net-ext\training-code\3-Services\PokemonApp\PokemonDL\connection-string.txt"
string connectionStringFilePath = "../../../../training-code/3-Services/PokemonApp/PokemonDL/connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository>(repo=>new SqlRepository(connectionString));
builder.Services.AddScoped<IPokemonLogic, PokemonLogic>();

//app here refers to the pipeline middleware
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

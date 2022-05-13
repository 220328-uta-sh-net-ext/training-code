using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using PokemonApi.Repository;
using PokemonBL;
using PokemonDL;
using System.Text;


//"C:\Revature\220328-uta-sh-.net-ext\training-code\3-Services\PokemonApp\PokemonDL\connection-string.txt"
// connection is in aooSettings.json or appSettings.development.json file
// string connectionStringFilePath = "../../../../training-code/3-Services/PokemonApp/PokemonDL/connection-string.txt";
// string connectionString = File.ReadAllText(connectionStringFilePath);

var builder = WebApplication.CreateBuilder(args);

//to access the appSettings.json file JWT token info we will use thi variable
ConfigurationManager Config=builder.Configuration;

// Add services to the container.
//boiler plate code to configure security with JWT 
builder.Services.AddAuthentication(options => {
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(o => {
    var key = Encoding.UTF8.GetBytes(Config["JWT:Key"]);
    o.SaveToken = true;
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidIssuer = Config["JWT:Issuer"],
        ValidAudience = Config["JWT:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateLifetime = true,
        ValidateIssuer = false,
        ValidateAudience = false
    };
});
builder.Services.AddMemoryCache();
builder.Services.AddControllers(options =>
    options.RespectBrowserAcceptHeader = true
    )
    .AddXmlSerializerFormatters();//adding xml formatter 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository>(repo=>new SqlRepository(Config.GetConnectionString("RestaurantDb")));
builder.Services.AddScoped<IPokemonLogic, PokemonLogic>();
builder.Services.AddSingleton<IJWTManagerRepository, JWTManagerRepository>();

//app here refers to the pipeline middleware
var app = builder.Build();
app.Logger.LogInformation("App Started");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();//this needs for authentication using JWT
app.UseAuthorization();

app.MapControllers();

app.Run();

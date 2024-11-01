using Backend.DTO;
using Backend.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddSingleton<IPersonaServices, PersonaService2>();
builder.Services.AddKeyedSingleton<IPersonaServices, PersonaService>("personaServices");
builder.Services.AddKeyedSingleton<IPersonaServices, PersonaService2>("personaServices2");

builder.Services.AddKeyedSingleton<IRandomServices, RandomService>("randomSingleton");
builder.Services.AddKeyedScoped<IRandomServices, RandomService>("randomScoped");
builder.Services.AddKeyedTransient<IRandomServices, RandomService>("randomTransient");
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

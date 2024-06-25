using ArenasLobby.Controller;
using ArenasLobby.Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.MapGet("/hello", () => "Hello, World!").WithName("HELLO, WORLD!").WithOpenApi();

app.MapGet("/create", (APlayerAccount roomCreator) =>
{
    CreateLobbyController controller = new CreateLobbyController();
    return roomCreator.Nickname;
});

app.Run();
using AfsarZMiniChallenge2to4.Services;
using AfsarZMiniChallenge2to4.Services.first;
using AfsarZMiniChallenge2to4.Services.second;
using AfsarZMiniChallenge2to4.Services.third;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFirstService, FirstService>();
builder.Services.AddScoped<ISecondService, SecondService>();
builder.Services.AddScoped<IThirdService, ThirdService>();

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

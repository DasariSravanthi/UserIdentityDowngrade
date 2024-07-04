using Microsoft.EntityFrameworkCore;
using Mapster;

using UserIdentity.Data;
using UserIdentity.Mapper.MapperService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<UserDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));

var config = new TypeAdapterConfig();
MapsterConfiguration.ConfigureMappings(config);

builder.Services.AddSingleton(config);

builder.Services.AddScoped<AppMapper>();

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

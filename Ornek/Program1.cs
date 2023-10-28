using Microsoft.EntityFrameworkCore;
using ZambarakUz.DataAccess.Context;
using ZambarakUz.DataAccess.Entites;
using ZambarakUz.DataAccess.Repositories.Abstract;
using ZambarakUz.DataAccess.Repositories.Concrete;

var builder = WebApplication.CreateBuilder(args);


var configuration = new ConfigurationBuilder()
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json")
    .Build();

// DbContext yapılandırması
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUserGroupRepository<UserGroup>, UserGroupRepository>();

// ...


// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
    
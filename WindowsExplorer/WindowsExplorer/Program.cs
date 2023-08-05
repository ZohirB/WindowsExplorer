using Microsoft.EntityFrameworkCore;
using WindowsExplorer.Models;
using WindowsExplorer.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IManageImage, ManageImage>();

var connectiosString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddTransient<DataSeeder>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectiosString)
);


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
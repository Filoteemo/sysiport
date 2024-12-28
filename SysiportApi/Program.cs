using Microsoft.EntityFrameworkCore;
using SysiportData;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<SysiportDbContext>(opt =>
{
    opt.UseInMemoryDatabase("SysiPortDB");
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

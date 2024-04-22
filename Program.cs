using Microsoft.EntityFrameworkCore;
using salesreportapi.Dal;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<SalesDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var connectionString = builder.Configuration.GetConnectionString("SalesConnection") ?? throw new InvalidOperationException("Connection string 'SalesConnection' not found.");


builder.Services.AddDbContext<SalesDbcontext>(options => options.UseSqlServer(connectionString));


//builder.Services.AddSingleton<IHostedService, BackgroundService>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SalesReportSystem v1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

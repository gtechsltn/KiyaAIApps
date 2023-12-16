// WebApplication: ASP.NET COre Host Env Class
// DI COntainer for Dependencies using IServiceCollection<ServiceDescriptor>
// ICOnfiguration, implemented by ConfigurationManager class to read appSettings.json
using Core_API.Models;
using Core_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<UCompanyContext>();
// Register the Data Services
builder.Services.AddScoped<IDataService<Department,int>, DepartmentDataService>();
// Options will be loaded along with DI
builder.Services.AddControllers(); // API Controllers

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// IAppliationBuilder for HTTP Request Pipeline with Middlewares 
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

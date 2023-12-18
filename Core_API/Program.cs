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

/*Register the CORS Service*/

builder.Services.AddCors(options => 
{
    options.AddPolicy("cors", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});


// Options will be loaded along with DI
builder.Services.AddControllers()
    /* Supress the Default Camel-asing for JSON Response */
     .AddJsonOptions(options=>options.JsonSerializerOptions.PropertyNamingPolicy = null); // API Controllers

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

/* Configure CORS Middleware*/
app.UseCors("cors");

app.UseAuthorization();
// Expose the API on Public Endpoint and wait for the HTTP REquest
app.MapControllers();
// Uses the INternal ROuting Table and Match the Incomming URL with Route Table
// https://MyServer/MyApp/MyCtrl
// MyCtrl as the ControllerNAme
// Detect Http Request Type
// Get / POst / Put / Delete
// Loads the ControllerContext, Varify Authorization(if applied), Inject Dependencies
// Map the Http Request Type to Action Method
// If Request Type is POST or PUT, Reads HTTP Request Body for MIME TYpe and Map the Data from Body with Input CLR (POCO) object 
app.Run();

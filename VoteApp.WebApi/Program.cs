using NLog;
using System.IO;
using VoteApp.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);
LogManager.LoadConfiguration(configFile: string.Concat(str0: Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.
builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureLoggerService();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHsts();
}
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseAuthorization();

app.MapControllers();

app.Run();

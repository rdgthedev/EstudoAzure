using EstudoAzure;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



var secrets = new Secrets();
var connectionString = app.Configuration.GetConnectionString("DefaultConnection");
app.Configuration.GetSection("Secrets").Bind(secrets);

app.MapGet("/", () => new
{
    ConnectionString = connectionString,
    Secrets = secrets
});

app.Run();

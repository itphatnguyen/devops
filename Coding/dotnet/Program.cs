using System.Net;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions());
builder.WebHost.UseKestrel(opts =>
{
    opts.Listen(IPAddress.Loopback, port: 8085);
    opts.ListenAnyIP(8085);
});

var app = builder.Build();

app.MapGet("/", async context =>
{
    string hostname = System.Net.Dns.GetHostName();
    Console.WriteLine("Host name: " + hostname);
    await Task.Delay(1000);
    await context.Response.WriteAsync("Dotnet App on Swarm, host: " + hostname);
});

app.Run();

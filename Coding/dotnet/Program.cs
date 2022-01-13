using System.Net;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions());
builder.WebHost.UseKestrel().UseUrls("http://0.0.0.0:8085");

var app = builder.Build();

app.MapGet("/", async context =>
{
    string hostname = System.Net.Dns.GetHostName();
    Console.WriteLine("Host name: " + hostname);
    await Task.Delay(1000);
    await context.Response.WriteAsync("Dotnet App on Swarm, host: " + hostname);
});

app.MapGet("/loop", async context =>
{
    HttpClient client = new HttpClient();
    for (int i = 0; i < 500; i++)
    {
        var aaa = await client.GetAsync("http://192.168.56.10:8085/");

        Console.WriteLine("call : "+i +" " + await aaa.Content.ReadAsStringAsync());
        await Task.Delay(1000);
    }
    await context.Response.WriteAsync("Done");
});

app.Run();

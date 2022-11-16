var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/Welcome", DoGreeting);
app.Run();

async Task DoGreeting(HttpResponse response, string guest = "Visitor")
{
    await response.WriteAsync(@$"
        <html>
            <head>
                <title>BasicWebApp</title>
            </head>
            <body>
                <h1>Welcome {guest}</h1>
                <b>Current Time: </b>{DateTime.Now}
            </body>
        </html>
    ");
}

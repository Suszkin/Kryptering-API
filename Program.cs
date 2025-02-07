var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/encrypt", (string text) =>
{
    string encrypted = new string(text.Select(c => (char)(c + 3)).ToArray());
    return Results.Ok(new { encrypted, message = "LuthorCorp har nu krypterat texten :)" });
});

app.MapGet("/decrypt", (string text) =>
{
    string decrypted = new string(text.Select(c => (char)(c - 3)).ToArray());
    return Results.Ok(new { decrypted, message = "Clark Kent har nu dekrypterat texten :)" });
});

app.Run();
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var version = app.Configuration["Lab:Version"] ?? "unknown";
var simulateFailure = app.Configuration.GetValue<bool>("Lab:SimulateFailure");

app.MapGet("/health", () =>
    Results.Json(
        new
        {
            status = simulateFailure ? "error" : "ok",
            version
        },
        statusCode: simulateFailure ? 503 : 200));

app.Run();

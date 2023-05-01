using TourTransfer.Persistence;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddPersistenceService();

app.Run();

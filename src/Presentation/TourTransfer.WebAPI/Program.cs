using TourTransfer.Persistence;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPersistenceService();



var app = builder.Build();


app.Run();

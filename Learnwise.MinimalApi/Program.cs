using Learnwise.MinimalApi.Common.ErrorHandling;
using Learnwise.MinimalApi.Common.Events.EventBus;
using Learnwise.MinimalApi.Common.Validation.Requests;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddExceptionHandling();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEventBus();
builder.Services.AddREquestsValidations();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseErrorHandling();

app.MapControllers();

app.Run();

namespace Learnwise.MinimalApi
{
    [UsedImplicitly]
    public sealed class Program;
}
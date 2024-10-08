using Learnwise.MinimalApi.Common.Clock;
using Learnwise.MinimalApi.Common.ErrorHandling;
using Learnwise.MinimalApi.Common.Events.EventBus;
using Learnwise.MinimalApi.Common.Validation.Requests;
using Learnwise.MinimalApi.Database;
using Learnwise.MinimalApi.Roadmaps;
using Learnwise.MinimalApi.Tasks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddExceptionHandling();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEventBus();
builder.Services.AddREquestsValidations();
builder.Services.AddClock();


builder.Services.AddDatabase(builder.Configuration);

builder.Services.AddTasks(builder.Configuration);
builder.Services.AddRoadmaps(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDatabase();

app.UseTasks();
app.UseRoadmaps();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseErrorHandling();

app.MapControllers();

app.MapTasks();
app.MapRoadmaps();

app.Run();

namespace Learnwise.MinimalApi
{
    [UsedImplicitly]
    public sealed class Program;
}
using AI_Playground.Web.Features.Learning;
using AI_Playground.Web.Features.Learning.LearningTree;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSingleton<LearningTreeReader>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapLearningRoutes();

app.UseHttpsRedirection();

app.Run();
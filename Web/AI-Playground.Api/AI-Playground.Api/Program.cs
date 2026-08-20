using AI_Playground.Web.Features.Learning;
using AI_Playground.Web.Features.Learning.LearningTree;
using AI_Playground.Web.Features.Learning.Markdown;

var builder = WebApplication.CreateBuilder(args);

var learningPath = builder.Configuration["LearningPath"]
    ?? throw new InvalidOperationException("Configuration 'LearningPath' is missing.");

var basePath = Path.GetFullPath(
    Path.Combine(
        builder.Environment.ContentRootPath,
        learningPath));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSingleton(new LearningDirectory(basePath));
builder.Services.AddSingleton<LearningTreeReader>();
builder.Services.AddSingleton<MarkdownReader>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapLearningRoutes();

app.UseHttpsRedirection();

app.Run();
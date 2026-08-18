using AI_Playground.Web.Features.Learning.LearningTree;
using AI_Playground.Web.Features.Learning.Markdown;

namespace AI_Playground.Web.Features.Learning
{
    public static class LearningEndpoints
    {
        public static RouteGroupBuilder MapLearningRoutes(this IEndpointRouteBuilder builder)
        {
            var group = builder.MapGroup("/api/learning");

            LearningTreeEndpoints.MapLearningTreeEndpoints(group);
            MarkdownEndpoints.MapMarkdownEndpoints(group);

            return group;
        }
    }

    public sealed record LearningDirectory(string Path);
}
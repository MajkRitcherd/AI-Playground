namespace AI_Playground.Web.Features.Learning
{
    public static class LearningEndpoints
    {
        public static RouteGroupBuilder MapLearningRoutes(this IEndpointRouteBuilder builder)
        {
            var group = builder
                .MapGroup("/api/learning");

            // Initially left empty before actual routes
            group.MapGet("/test", (string name = "world") =>
            {
                return Results.Ok($"Hello {name}");
            });

            return group;
        }
    }
}

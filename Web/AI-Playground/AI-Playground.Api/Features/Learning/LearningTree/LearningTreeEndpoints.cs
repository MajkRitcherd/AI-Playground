namespace AI_Playground.Web.Features.Learning.LearningTree
{
    public static class LearningTreeEndpoints
    {
        public static void MapLearningTreeEndpoints(this RouteGroupBuilder group)
        {
            group.MapGet("/tree", (LearningTreeReader reader) =>
            {
                var tree = reader.Read();

                return Results.Ok(tree);
            });
        }
    }
}

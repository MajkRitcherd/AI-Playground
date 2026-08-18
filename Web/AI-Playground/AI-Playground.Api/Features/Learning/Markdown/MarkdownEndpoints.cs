namespace AI_Playground.Web.Features.Learning.Markdown
{
    public static class MarkdownEndpoints
    {
        public static void MapMarkdownEndpoints(this RouteGroupBuilder group)
        {
            group.MapGet("/content/{*path}", async (string path, MarkdownReader reader, CancellationToken cancellationToken) =>
            {
                var result = await reader.ReadAsync(path, cancellationToken);

                return result.Status switch
                {
                    MarkdownReadStatus.Success => Results.Text(result.Content, "text/markdown"),
                    MarkdownReadStatus.NotFound => Results.NotFound(),
                    MarkdownReadStatus.InvalidPath => Results.NotFound(),
                    MarkdownReadStatus.NotMarkdown => Results.NotFound(),
                    MarkdownReadStatus.Error => Results.NotFound(),
                    _ => Results.Problem()

                };
            });
        }
    }
}

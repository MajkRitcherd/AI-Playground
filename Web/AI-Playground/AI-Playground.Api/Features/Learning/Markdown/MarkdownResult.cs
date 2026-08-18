namespace AI_Playground.Web.Features.Learning.Markdown
{
    public sealed record MarkdownResult(
        MarkdownReadStatus Status,
        string? Content = null);

    public enum MarkdownReadStatus
    {
        Success,
        NotFound,
        InvalidPath,
        NotMarkdown,
        Error,
    }
}
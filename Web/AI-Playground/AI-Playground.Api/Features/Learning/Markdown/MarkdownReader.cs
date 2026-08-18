namespace AI_Playground.Web.Features.Learning.Markdown
{
    public sealed class MarkdownReader(LearningDirectory directory, ILogger<MarkdownReader> logger)
    {
        private readonly string _basePath = directory.Path;
        private readonly ILogger<MarkdownReader> _logger = logger;

        public async Task<MarkdownResult> ReadAsync(string relativePath, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(relativePath))
                return new MarkdownResult(MarkdownReadStatus.InvalidPath);

            if (!relativePath.EndsWith(".md", StringComparison.OrdinalIgnoreCase))
                return new MarkdownResult(MarkdownReadStatus.NotMarkdown);

            var fullPath = Path.GetFullPath(
                Path.Combine(_basePath, relativePath));

            if (!IsInsideBasePath(fullPath))
                return new MarkdownResult(MarkdownReadStatus.InvalidPath);

            if (!File.Exists(fullPath))
                return new MarkdownResult(MarkdownReadStatus.NotFound);

            try
            {
                var content = await File.ReadAllTextAsync(fullPath, cancellationToken);
                return new MarkdownResult(MarkdownReadStatus.Success, content);
            }
            catch (OperationCanceledException ex)
            {
                _logger.Log(LogLevel.Information, ex, "Operation was cancelled.");
                throw;
            }
            catch (IOException ex)
            {
                _logger.Log(LogLevel.Error, ex, "Failed to read markdown file: '{FullPath}'", fullPath);
                return new MarkdownResult(MarkdownReadStatus.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                _logger.Log(LogLevel.Error, ex, "Unauthorized acces to file: '{FullPath}'", fullPath);
                return new MarkdownResult(MarkdownReadStatus.Error);
            }
        }

        private bool IsInsideBasePath(string fullPath)
        {
            var basePath = Path.GetFullPath(_basePath).TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar;

            return fullPath.StartsWith(basePath, StringComparison.OrdinalIgnoreCase);
        }
    }
}
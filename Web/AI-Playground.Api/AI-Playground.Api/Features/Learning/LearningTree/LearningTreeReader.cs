namespace AI_Playground.Web.Features.Learning.LearningTree
{
    public sealed class LearningTreeReader(LearningDirectory directory)
    {
        private readonly string _basePath = directory.Path;

        public LearningNodeDTO Read()
        {
            if (!Directory.Exists(_basePath))
                throw new DirectoryNotFoundException($"Learning directory was not found: {_basePath}");

            var root = new DirectoryInfo(_basePath);
            return BuildNode(root);
        }

        private LearningNodeDTO BuildNode(DirectoryInfo directoryInfo)
        {
            var children = new List<LearningNodeDTO>();

            foreach (var subDirectory in directoryInfo.GetDirectories())
                children.Add(BuildNode(subDirectory));

            foreach (var file in directoryInfo.GetFiles("*.md"))
                children.Add(new LearningNodeDTO(
                    file.Name[..^file.Extension.Length],
                    GetRelativePath(file.FullName),
                    false,
                    []
                ));

            return new LearningNodeDTO(
                directoryInfo.Name,
                GetRelativePath(directoryInfo.FullName),
                true,
                children);
        }

        private string GetRelativePath(string fullName)
        {
            var relativePath = Path
                .GetRelativePath(_basePath, fullName)
                .Replace('\\', '/');

            return string.Equals(relativePath, ".")
                ? fullName
                : relativePath;
        }
    }
}
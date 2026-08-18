namespace AI_Playground.Web.Features.Learning.LearningTree
{
    public sealed record LearningNodeDTO(
        string Name,
        string Path,
        bool IsDirectory,
        IReadOnlyList<LearningNodeDTO> Children
    );
}
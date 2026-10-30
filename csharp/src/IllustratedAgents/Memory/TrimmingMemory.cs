using System.Text.Json.Nodes;

namespace IllustratedAgents;

/// <summary>Short-term memory that keeps the system message plus only the last two turns. Chapter 4.</summary>
public class TrimmingMemory : Memory
{
    /// <summary>How many non-system messages survive: two turns of user + assistant.</summary>
    public const int KeptMessages = 4;

    public override async Task AddAsync(
        string role,
        string? content,
        JsonObject? toolCall = null,
        string? imageData = null,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 4: TrimmingMemory.AddAsync. See chapters/Chapter04/README.md");
    }
}

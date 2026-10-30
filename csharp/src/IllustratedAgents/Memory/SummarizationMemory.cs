using System.Text;
using System.Text.Json.Nodes;

namespace IllustratedAgents;

/// <summary>
/// Short-term memory that compresses the conversation into a running summary after every assistant
/// message. The summary lives in a single system message. Chapter 4.
/// </summary>
public class SummarizationMemory : Memory
{
    private readonly ILlm _llm;

    public SummarizationMemory(ILlm llm) => _llm = llm;

    public override async Task AddAsync(
        string role,
        string? content,
        JsonObject? toolCall = null,
        string? imageData = null,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 4: SummarizationMemory.AddAsync. See chapters/Chapter04/README.md");
    }
}

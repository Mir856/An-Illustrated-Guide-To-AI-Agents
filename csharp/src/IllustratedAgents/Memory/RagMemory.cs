using System.Text.Json.Nodes;

namespace IllustratedAgents;

/// <summary>
/// Long-term memory with retrieval-augmented generation: every user message is stored together with the
/// documents most similar to it. Chapter 4.
/// </summary>
/// <remarks>
/// Embedding the documents needs a model call, and a constructor can't be awaited, so you build one
/// with <see cref="CreateAsync"/>.
/// </remarks>
public class RagMemory : Memory
{
    private readonly IEmbeddingModel _embeddingModel;

    private RagMemory(IEmbeddingModel embeddingModel, IReadOnlyList<string> documents, IReadOnlyList<float[]> embeddings)
    {
        _embeddingModel = embeddingModel;
        Documents = documents;
        Embeddings = embeddings;
    }

    public IReadOnlyList<string> Documents { get; }
    public IReadOnlyList<float[]> Embeddings { get; }

    /// <summary>Embed every document once, up front, and return the memory.</summary>
    public static async Task<RagMemory> CreateAsync(
        IEmbeddingModel embeddingModel,
        IReadOnlyList<string> documents,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 4: RagMemory.CreateAsync. See chapters/Chapter04/README.md");
    }

    public override async Task AddAsync(
        string role,
        string? content,
        JsonObject? toolCall = null,
        string? imageData = null,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 4: RagMemory.AddAsync. See chapters/Chapter04/README.md");
    }

    /// <summary>The <paramref name="k"/> documents most similar to <paramref name="query"/>, best first.</summary>
    public async Task<IReadOnlyList<string>> SearchAsync(string query, int k = 3, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 4: RagMemory.SearchAsync. See chapters/Chapter04/README.md");
    }

    /// <summary>Cosine similarity: 1 means the same direction, 0 unrelated, -1 opposite.</summary>
    public static double Cosine(float[] a, float[] b)
    {
        throw new NotImplementedException("Chapter 4: RagMemory.Cosine. See chapters/Chapter04/README.md");
    }
}

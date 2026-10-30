using System.Text;
using System.Text.Json.Nodes;

namespace IllustratedAgents;

/// <summary>
/// Turns text into an embedding through any OpenAI-compatible <c>/embeddings</c> endpoint. Chapter 4.
/// </summary>
public sealed class EmbeddingModel : IEmbeddingModel
{
    private static readonly HttpClient SharedHttp = new() { Timeout = TimeSpan.FromMinutes(5) };

    private readonly HttpClient _http;

    public EmbeddingModel(string model, string baseUrl = "http://localhost:11434/v1", HttpClient? httpClient = null)
    {
        Model = model;
        BaseUrl = baseUrl.TrimEnd('/');
        _http = httpClient ?? SharedHttp;
    }

    public string Model { get; }
    public string BaseUrl { get; }

    public async Task<float[]> EmbedAsync(string text, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 4: EmbeddingModel.EmbedAsync. See chapters/Chapter04/README.md");
    }
}

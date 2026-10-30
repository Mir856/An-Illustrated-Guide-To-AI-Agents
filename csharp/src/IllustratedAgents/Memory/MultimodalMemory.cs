using System.Text.Json.Nodes;

namespace IllustratedAgents;

/// <summary>Memory that can store an image alongside a message. Chapter 9.</summary>
public class MultimodalMemory : Memory
{
    public override Task AddAsync(
        string role,
        string? content,
        JsonObject? toolCall = null,
        string? imageData = null,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 9: MultimodalMemory.AddAsync. See chapters/Chapter09/README.md");
    }

    /// <summary>PNG files start with the bytes that encode to "iVBOR"; everything else is treated as JPEG.</summary>
    private static string GuessMimeType(string base64) =>
        base64.StartsWith("iVBOR") ? "image/png" : "image/jpeg";
}

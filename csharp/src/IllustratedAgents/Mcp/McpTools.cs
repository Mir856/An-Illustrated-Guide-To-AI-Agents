using System.Text.Json.Nodes;

namespace IllustratedAgents;

/// <summary>
/// A text-based tool registry filled from an MCP server: every tool the server lists becomes a tool
/// the agent can call. Chapter 5.
/// </summary>
/// <remarks>Like the Python <c>MCPTools</c>, it extends <see cref="Tools"/>, so the model calls MCP tools with a JSON blob.</remarks>
public sealed class McpTools : Tools, IAsyncDisposable
{
    private readonly McpClient _client;

    private McpTools(McpClient client) => _client = client;

    /// <summary>List the server's tools and register a caller for each one.</summary>
    public static async Task<McpTools> ConnectAsync(McpClient client, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 5: McpTools.ConnectAsync. See chapters/Chapter05/README.md");
    }

    /// <summary>Start a server process and connect to it in one step.</summary>
    public static async Task<McpTools> StartAsync(string command, IEnumerable<string> arguments, CancellationToken cancellationToken = default)
    {
        var client = await McpClient.StartAsync(command, arguments, cancellationToken);
        return await ConnectAsync(client, cancellationToken);
    }

    public ValueTask DisposeAsync() => _client.DisposeAsync();
}

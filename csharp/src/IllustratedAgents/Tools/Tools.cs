using System.Text.Json;
using System.Text.Json.Nodes;

namespace IllustratedAgents;

/// <summary>A registered tool: the C# function that does the work, and how the model should use it.</summary>
public sealed record ToolEntry(Delegate Function, string Description);

/// <summary>
/// The tool registry, using text-based tool calling: the model writes a JSON blob such as
/// <c>{"tool": "multiply", "kwargs": {"a": "5.1", "b": "7.3"}}</c> in its reply. Chapter 5.
/// </summary>
public class Tools
{
    private static readonly JsonDocumentOptions LenientJson = new() { AllowTrailingCommas = true };

    private readonly Func<string, bool> _approve;

    /// <param name="requiresApproval">Tools that must be approved by a person before they run.</param>
    /// <param name="approve">
    /// Asks a person whether a tool may run. Defaults to a yes/no question on the console; tests pass their own.
    /// </param>
    public Tools(IEnumerable<string>? requiresApproval = null, Func<string, bool>? approve = null)
    {
        RequiresApproval = new HashSet<string>(requiresApproval ?? []);
        _approve = approve ?? AskOnConsole;
    }

    /// <summary>Every registered tool by name, in the order they were added.</summary>
    public OrderedDictionary<string, ToolEntry> Registry { get; } = new();

    public ISet<string> RequiresApproval { get; }

    /// <summary>Register a tool the agent can use.</summary>
    public void AddTool(string name, Delegate function, string description = "")
    {
        throw new NotImplementedException("Chapter 5: Tools.AddTool. See chapters/Chapter05/README.md");
    }

    /// <summary>One line per tool: <c>`name`: description</c>.</summary>
    public string Descriptions
    {
        get
        {
            throw new NotImplementedException("Chapter 5: Tools.Descriptions. See chapters/Chapter05/README.md");
        }
    }

    /// <summary>The part of the system prompt that tells the model which tools exist and how to call one.</summary>
    public virtual string Prompt
    {
        get
        {
            throw new NotImplementedException("Chapter 5: Tools.Prompt. See chapters/Chapter05/README.md");
        }
    }

    /// <summary>Native tool definitions to send with the request. Text-based tools send none.</summary>
    public virtual JsonArray? Schemas => null;

    /// <summary>
    /// Find a JSON tool call in the model's text and attach it to the response as
    /// <c>{"tool": ..., "kwargs": ...}</c>. Text with no tool call comes back unchanged.
    /// </summary>
    public virtual Response Parse(Response response)
    {
        throw new NotImplementedException("Chapter 5: Tools.Parse. See chapters/Chapter05/README.md");
    }

    /// <summary>
    /// Run the tool named in <c>response.ToolCall</c>. Asks for approval first when the tool requires it.
    /// Unknown tools, denied tools and tools that throw all come back as a message for the model, not an exception.
    /// </summary>
    public virtual async Task<object?> ExecuteAsync(Response response, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 5: Tools.ExecuteAsync. See chapters/Chapter05/README.md");
    }

    /// <summary>How a tool result goes back into memory: here, as a user message starting with OBSERVATION.</summary>
    public virtual (string Role, string Content) Observation(object? result)
    {
        throw new NotImplementedException("Chapter 5: Tools.Observation. See chapters/Chapter05/README.md");
    }

    /// <summary>
    /// The stopping rule. Done when there is no tool call, or when the tool is <c>final_answer</c>, in which
    /// case its kwargs become the response's content.
    /// </summary>
    public virtual bool IsDone(Response response)
    {
        throw new NotImplementedException("Chapter 5: Tools.IsDone. See chapters/Chapter05/README.md");
    }

    private static bool AskOnConsole(string toolName)
    {
        Console.Write($"Allow {toolName}? [y/N] ");
        var answer = Console.ReadLine()?.Trim().ToLowerInvariant();
        return answer is "y" or "yes";
    }
}

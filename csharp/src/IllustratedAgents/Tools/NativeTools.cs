using System.Text.Json.Nodes;

namespace IllustratedAgents;

/// <summary>
/// The tool registry using native function calling: tools are sent as JSON schemas, and the model
/// returns a structured tool call instead of a JSON blob in its text. Chapter 5.
/// </summary>
public class NativeTools : Tools
{
    public NativeTools(IEnumerable<string>? requiresApproval = null, Func<string, bool>? approve = null)
        : base(requiresApproval, approve)
    {
    }

    /// <summary>One function definition per registered tool.</summary>
    public override JsonArray? Schemas
    {
        get
        {
            throw new NotImplementedException("Chapter 5: NativeTools.Schemas. See chapters/Chapter05/README.md");
        }
    }

    /// <summary>Native tool calling needs no instructions in the prompt.</summary>
    public override string Prompt
    {
        get
        {
            throw new NotImplementedException("Chapter 5: NativeTools.Prompt. See chapters/Chapter05/README.md");
        }
    }

    /// <summary>
    /// Converts the API's <c>{"function": {"name", "arguments"}}</c> into <c>{"tool", "kwargs"}</c>.
    /// Arguments may arrive as a JSON string or as an object.
    /// </summary>
    public override Response Parse(Response response)
    {
        throw new NotImplementedException("Chapter 5: NativeTools.Parse. See chapters/Chapter05/README.md");
    }

    /// <summary>Native tool results go back with the "tool" role, with no OBSERVATION prefix.</summary>
    public override (string Role, string Content) Observation(object? result)
    {
        throw new NotImplementedException("Chapter 5: NativeTools.Observation. See chapters/Chapter05/README.md");
    }

    /// <summary>No tool call means the agent is done.</summary>
    public override bool IsDone(Response response)
    {
        throw new NotImplementedException("Chapter 5: NativeTools.IsDone. See chapters/Chapter05/README.md");
    }
}

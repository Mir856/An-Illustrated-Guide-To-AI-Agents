using System.ComponentModel;
using System.Reflection;
using System.Text.Json.Nodes;

namespace IllustratedAgents;

/// <summary>
/// Builds an OpenAI-style function definition from a C# delegate: the C# version of Python's
/// <c>tool_to_schema</c>. Chapter 5, native tool calling.
/// </summary>
public static class ToolSchema
{
    /// <summary>
    /// The schema for one tool. The name is the name you registered (C# method names are PascalCase,
    /// and lambdas have compiler-generated names). The description comes from a
    /// <see cref="DescriptionAttribute"/> on the method, or falls back to <paramref name="fallbackDescription"/>.
    /// </summary>
    public static JsonObject FromDelegate(string name, Delegate function, string fallbackDescription = "")
    {
        throw new NotImplementedException("Chapter 5: ToolSchema.FromDelegate. See chapters/Chapter05/README.md");
    }

    /// <summary>Maps a C# type to a JSON Schema type name, the way Python's <c>TYPE_MAP</c> does.</summary>
    public static string JsonTypeOf(Type type)
    {
        throw new NotImplementedException("Chapter 5: ToolSchema.JsonTypeOf. See chapters/Chapter05/README.md");
    }
}

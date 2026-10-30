using System.ComponentModel;
using System.Diagnostics;

namespace IllustratedAgents;

/// <summary>
/// The coding agent's tools from chapter 10, locked to one workspace folder: read, list and write files,
/// and run C# code. Writing and running need a person's approval.
/// </summary>
/// <remarks>
/// The Python version runs Python. This one runs C# through .NET 10 file-based apps
/// (<c>dotnet run snippet.cs</c>), so it needs no extra packages. The first run of each snippet compiles it,
/// which takes a few seconds.
/// </remarks>
public sealed class CodeTools
{
    public CodeTools(string workspace)
    {
        Root = Path.GetFullPath(workspace);
        Directory.CreateDirectory(Root);
    }

    /// <summary>The folder the tools may touch. Nothing outside it is readable or writable.</summary>
    public string Root { get; }

    /// <summary>A native-tool registry with all four tools; write_file and run_csharp require approval.</summary>
    public NativeTools CreateRegistry(Func<string, bool>? approve = null)
    {
        throw new NotImplementedException("Chapter 10: CodeTools.CreateRegistry. See chapters/Chapter10/README.md");
    }

    /// <summary>
    /// Resolve <paramref name="path"/> inside the workspace. A path that escapes it, such as
    /// <c>../secrets.txt</c> or an absolute path elsewhere, throws <see cref="UnauthorizedAccessException"/>.
    /// </summary>
    public string SafePath(string path)
    {
        throw new NotImplementedException("Chapter 10: CodeTools.SafePath. See chapters/Chapter10/README.md");
    }

    [Description("Read a file's contents.")]
    public string ReadFile(string path)
    {
        throw new NotImplementedException("Chapter 10: CodeTools.ReadFile. See chapters/Chapter10/README.md");
    }

    [Description("List files in a directory.")]
    public string ListFiles(string directory = ".")
    {
        throw new NotImplementedException("Chapter 10: CodeTools.ListFiles. See chapters/Chapter10/README.md");
    }

    [Description("Write content to a file.")]
    public string WriteFile(string path, string content)
    {
        throw new NotImplementedException("Chapter 10: CodeTools.WriteFile. See chapters/Chapter10/README.md");
    }

    [Description("Run a complete C# program (top-level statements) and return its output.")]
    public async Task<string> RunCSharpAsync(string code, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 10: CodeTools.RunCSharpAsync. See chapters/Chapter10/README.md");
    }
}

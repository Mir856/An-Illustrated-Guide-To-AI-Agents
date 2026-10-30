namespace IllustratedAgents;

/// <summary>
/// A registry for tools and skills. A skill is a recipe in a folder with a SKILL.md file. The model
/// sees only its name and description (tier 1); calling it like a tool returns the full instructions
/// (tier 2) and the other files in the folder (tier 3). Chapter 5.
/// </summary>
public class Skills : NativeTools
{
    public Skills(IEnumerable<string>? requiresApproval = null, Func<string, bool>? approve = null)
        : base(requiresApproval, approve)
    {
    }

    /// <summary>Load the skill in <paramref name="skillDirectory"/> and register it as a tool with no parameters.</summary>
    public void AddSkill(string skillDirectory)
    {
        throw new NotImplementedException("Chapter 5: Skills.AddSkill. See chapters/Chapter05/README.md");
    }

    public override string Prompt
    {
        get
        {
            throw new NotImplementedException("Chapter 5: Skills.Prompt. See chapters/Chapter05/README.md");
        }
    }

    /// <summary>Reads simple <c>key: value</c> lines, which is all SKILL.md frontmatter needs here.</summary>
    public static Dictionary<string, string> ParseFrontmatter(string text)
    {
        throw new NotImplementedException("Chapter 5: Skills.ParseFrontmatter. See chapters/Chapter05/README.md");
    }
}

namespace IllustratedAgents;

/// <summary>
/// Every few steps, asks a model to critique the agent's recent work and adds the critique to memory as a
/// course correction. Chapter 6.
/// </summary>
/// <remarks>
/// Like the Python version, the TinyAgent loop doesn't call this on its own. Wiring it in is the
/// chapter's stretch goal.
/// </remarks>
public sealed class Reflexion
{
    private readonly ILlm _llm;

    public Reflexion(ILlm llm, int interval = 3)
    {
        _llm = llm;
        Interval = interval;
    }

    public int Interval { get; }

    /// <summary>
    /// On steps 3, 6, 9 and so on (for an interval of 3), critique the last six messages and add
    /// <c>[Reflection] critique</c> to memory as a user message. Other steps, including step 0, do nothing.
    /// </summary>
    public async Task ReflectAsync(Memory memory, int step, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 6: Reflexion.ReflectAsync. See chapters/Chapter06/README.md");
    }
}

namespace IllustratedAgents.Chapters.Ch04;

/// <summary>TinyAgent with memory: each run sees the whole conversation so far. Chapter 4.</summary>
public sealed class TinyAgent : IAgent
{
    private readonly ILlm _llm;

    public TinyAgent(ILlm llm, Memory memory)
    {
        _llm = llm;
        Memory = memory;
    }

    public Memory Memory { get; }

    public Trajectory Trajectory { get; } = new();

    /// <summary>Add the task to memory, start a run, take one step.</summary>
    public async Task<string> RunAsync(string task, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 4: TinyAgent.RunAsync. See chapters/Chapter04/README.md");
    }

    /// <summary>Generate from everything in memory, store the reply in memory and the trajectory, return it.</summary>
    private async Task<string> StepAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException("Chapter 4: TinyAgent.StepAsync. See chapters/Chapter04/README.md");
    }
}

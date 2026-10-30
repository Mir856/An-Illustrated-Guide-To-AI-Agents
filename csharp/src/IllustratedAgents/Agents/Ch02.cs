namespace IllustratedAgents.Chapters.Ch02;

/// <summary>TinyAgent with a brain: one call to the model per task, recorded in a trajectory. Chapter 2.</summary>
public sealed class TinyAgent : IAgent
{
    private readonly ILlm _llm;

    public TinyAgent(ILlm llm) => _llm = llm;

    public Trajectory Trajectory { get; } = new();

    /// <summary>Start a run in the trajectory, take one step, and return the model's answer.</summary>
    public async Task<string> RunAsync(string task, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 2: TinyAgent.RunAsync. See chapters/Chapter02/README.md");
    }

    /// <summary>Send the task as a single user message, record the response, return its content.</summary>
    private async Task<string> StepAsync(string task, CancellationToken cancellationToken)
    {
        throw new NotImplementedException("Chapter 2: TinyAgent.StepAsync. See chapters/Chapter02/README.md");
    }
}

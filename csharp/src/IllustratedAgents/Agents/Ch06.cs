namespace IllustratedAgents.Chapters.Ch06;

/// <summary>
/// The autonomous TinyAgent: it loops THOUGHT, ACTION, OBSERVATION until it has an answer or runs out of
/// steps. Chapter 6.
/// </summary>
public class TinyAgent : IAgent
{
    public const string MaxStepsMessage = "Max steps reached without completion.";

    private bool _systemPromptAdded;

    public TinyAgent(ILlm llm, Memory memory, Tools tools, ReAct planner)
    {
        Llm = llm;
        Memory = memory;
        Tools = tools;
        Planner = planner;
    }

    protected ILlm Llm { get; }
    public Memory Memory { get; }
    public Tools Tools { get; }
    public ReAct Planner { get; }
    public Trajectory Trajectory { get; } = new();

    /// <summary>"You are a helpful assistant." followed by the planner's prompt, then the tools' prompt.</summary>
    public string SystemPrompt
    {
        get
        {
            throw new NotImplementedException("Chapter 6: TinyAgent.SystemPrompt. See chapters/Chapter06/README.md");
        }
    }

    public Task<string> RunAsync(string task, CancellationToken cancellationToken = default) =>
        RunAsync(task, imageData: null, cancellationToken);

    /// <summary>
    /// Add the system prompt on the first run, add the task, start a run, then step until a step returns an
    /// answer. After <see cref="ReAct.MaxSteps"/> steps without one, return <see cref="MaxStepsMessage"/>.
    /// </summary>
    protected async Task<string> RunAsync(string task, string? imageData, CancellationToken cancellationToken)
    {
        throw new NotImplementedException("Chapter 6: TinyAgent.RunAsync. See chapters/Chapter06/README.md");
    }

    /// <summary>
    /// One step: generate, store the reply, let the planner parse it and then the tools. Return the answer if
    /// done; otherwise run the tool and return null so the loop continues.
    /// </summary>
    protected async Task<string?> StepAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException("Chapter 6: TinyAgent.StepAsync. See chapters/Chapter06/README.md");
    }

    /// <summary>ACTION: run the tool. OBSERVATION: store the result in memory and the trajectory.</summary>
    protected async Task ExecuteActionAsync(Response response, CancellationToken cancellationToken)
    {
        throw new NotImplementedException("Chapter 6: TinyAgent.ExecuteActionAsync. See chapters/Chapter06/README.md");
    }
}

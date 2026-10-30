namespace IllustratedAgents.Chapters.Ch05;

/// <summary>
/// TinyAgent with tools: in one step the model either answers or calls a tool. Not autonomous yet: after a
/// tool runs, the run ends with the observation. Chapter 5.
/// </summary>
public sealed class TinyAgent : IAgent
{
    private readonly ILlm _llm;
    private bool _systemPromptAdded;

    public TinyAgent(ILlm llm, Memory memory, Tools tools)
    {
        _llm = llm;
        Memory = memory;
        Tools = tools;
    }

    public Memory Memory { get; }
    public Tools Tools { get; }
    public Trajectory Trajectory { get; } = new();

    /// <summary>"You are a helpful assistant." followed by the tools' prompt.</summary>
    public string SystemPrompt
    {
        get
        {
            throw new NotImplementedException("Chapter 5: TinyAgent.SystemPrompt. See chapters/Chapter05/README.md");
        }
    }

    /// <summary>
    /// On the first run, add the system prompt to memory (a constructor can't await). Then add the task,
    /// start a run, and take one step.
    /// </summary>
    public async Task<string> RunAsync(string task, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 5: TinyAgent.RunAsync. See chapters/Chapter05/README.md");
    }

    /// <summary>
    /// THOUGHT: generate with the tool schemas, store the reply (and any tool call) in memory. Parse the tool
    /// call. ANSWER: if done, record and return the content. Otherwise run the tool and return the observation.
    /// </summary>
    private async Task<string> StepAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException("Chapter 5: TinyAgent.StepAsync. See chapters/Chapter05/README.md");
    }

    /// <summary>ACTION: run the tool. OBSERVATION: store the result in memory and the trajectory, and return it.</summary>
    private async Task<string> ExecuteActionAsync(Response response, CancellationToken cancellationToken)
    {
        throw new NotImplementedException("Chapter 5: TinyAgent.ExecuteActionAsync. See chapters/Chapter05/README.md");
    }
}

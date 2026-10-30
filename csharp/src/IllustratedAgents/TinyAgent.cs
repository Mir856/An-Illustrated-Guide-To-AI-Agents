namespace IllustratedAgents;

/// <summary>
/// The finished TinyAgent: model, memory, tools, planning, images, and a display that shows each THOUGHT,
/// ACTION, OBSERVATION and ANSWER as it happens. Chapter 10.
/// </summary>
public sealed class TinyAgent : IAgent
{
    public const string MaxStepsMessage = "Max steps reached without completion.";

    private readonly ILlm _llm;
    private bool _systemPromptAdded;

    public TinyAgent(ILlm llm, Memory memory, Tools tools, ReAct planner, Display? display = null)
    {
        _llm = llm;
        Memory = memory;
        Tools = tools;
        Planner = planner;
        Display = display ?? new Display();
    }

    public Memory Memory { get; }
    public Tools Tools { get; }
    public ReAct Planner { get; }
    public Display Display { get; }
    public Trajectory Trajectory { get; } = new();

    public string SystemPrompt => "You are a helpful assistant.\n\n" + Planner.Prompt + Tools.Prompt;

    public Task<string> RunAsync(string task, CancellationToken cancellationToken = default) =>
        RunAsync(task, imageData: null, cancellationToken);

    /// <summary>The chapter 6 loop, with an optional image (chapter 9).</summary>
    public async Task<string> RunAsync(string task, string? imageData, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 10: TinyAgent.RunAsync. See chapters/Chapter10/README.md");
    }

    /// <summary>
    /// The chapter 6 step, telling the display what's happening: <see cref="Display.Thinking"/> before the model
    /// call, <see cref="Display.ShowResponse"/> after it.
    /// </summary>
    private async Task<string?> StepAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException("Chapter 10: TinyAgent.StepAsync. See chapters/Chapter10/README.md");
    }

    /// <summary>
    /// The chapter 6 action, telling the display what's happening: <see cref="Display.ShowToolCall"/> before
    /// the tool runs, <see cref="Display.ShowObservation"/> after.
    /// </summary>
    private async Task ExecuteActionAsync(Response response, CancellationToken cancellationToken)
    {
        throw new NotImplementedException("Chapter 10: TinyAgent.ExecuteActionAsync. See chapters/Chapter10/README.md");
    }
}

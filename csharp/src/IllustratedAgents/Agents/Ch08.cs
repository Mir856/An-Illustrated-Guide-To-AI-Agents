namespace IllustratedAgents.Chapters.Ch08;

/// <summary>
/// Multi-agent collaboration with agents as tools: two specialists, and an orchestrator whose only tools
/// are "ask the math agent" and "ask the date agent". Chapter 8.
/// </summary>
public static class Team
{
    /// <summary>A native-tool agent with <c>add</c>, <c>subtract</c> and <c>multiply</c>.</summary>
    public static Ch06.TinyAgent CreateMathAgent(ILlm llm)
    {
        throw new NotImplementedException("Chapter 8: Team.CreateMathAgent. See chapters/Chapter08/README.md");
    }

    /// <summary>A native-tool agent with <c>today</c> and <c>days_between</c>.</summary>
    public static Ch06.TinyAgent CreateDateAgent(ILlm llm)
    {
        throw new NotImplementedException("Chapter 8: Team.CreateDateAgent. See chapters/Chapter08/README.md");
    }

    /// <summary>
    /// An orchestrator with two tools, <c>ask_math_agent(question)</c> and <c>ask_date_agent(question)</c>,
    /// each of which runs the specialist on the question and returns its answer.
    /// </summary>
    public static Ch06.TinyAgent CreateOrchestrator(ILlm llm, IAgent mathAgent, IAgent dateAgent)
    {
        throw new NotImplementedException("Chapter 8: Team.CreateOrchestrator. See chapters/Chapter08/README.md");
    }
}

using System.Globalization;
using System.Text.RegularExpressions;

namespace IllustratedAgents;

/// <summary>One benchmark question: the task, and either the expected answer or a check function.</summary>
public sealed record Example(string Task, string? Expected = null, Func<string, bool>? Check = null);

/// <summary>Scores a prediction against an example: 0 is a fail, 1 a pass, anything between is partial credit.</summary>
public delegate Task<double> Scorer(string prediction, Example example);

/// <summary>A named set of examples and the scorer that grades them. Chapter 7.</summary>
public sealed record Benchmark(string Name, IReadOnlyList<Example> Examples, Scorer Scorer);

/// <summary>How the agent did on one example.</summary>
public sealed record ExampleResult(string Prediction, double Score);

/// <summary>How the agent did on a whole benchmark.</summary>
public sealed record EvaluationResult(string Name, double PassRate, IReadOnlyList<ExampleResult> Results);

/// <summary>Runs a fresh agent on every example in a benchmark and averages the scores. Chapter 7.</summary>
public sealed class Evaluator
{
    private readonly Func<IAgent> _createAgent;

    /// <param name="createAgent">Builds a new agent, so no example sees another example's memory.</param>
    public Evaluator(Func<IAgent> createAgent) => _createAgent = createAgent;

    public async Task<EvaluationResult> RunAsync(Benchmark benchmark, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Chapter 7: Evaluator.RunAsync. See chapters/Chapter07/README.md");
    }
}

/// <summary>The three scorers from chapter 7.</summary>
public static class Scorers
{
    /// <summary>
    /// Exact match for multiple choice: the first standalone letter A to J in the prediction must equal
    /// <see cref="Example.Expected"/>. No letter scores 0.
    /// </summary>
    public static Task<double> ExactMatch(string prediction, Example example)
    {
        throw new NotImplementedException("Chapter 7: Scorers.ExactMatch. See chapters/Chapter07/README.md");
    }

    /// <summary>Programmatic check: the example's own <see cref="Example.Check"/> decides.</summary>
    public static Task<double> Programmatic(string prediction, Example example)
    {
        throw new NotImplementedException("Chapter 7: Scorers.Programmatic. See chapters/Chapter07/README.md");
    }

    /// <summary>
    /// LLM-as-a-judge: <paramref name="judge"/> scores the response against the expected answer from 0.0 to 1.0.
    /// A reply that isn't a number scores 0.
    /// </summary>
    public static Scorer Judge(ILlm judge)
    {
        throw new NotImplementedException("Chapter 7: Scorers.Judge. See chapters/Chapter07/README.md");
    }
}

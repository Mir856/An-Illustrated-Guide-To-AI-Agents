using System.ComponentModel;

namespace IllustratedAgents;

/// <summary>One sub-task in a plan.</summary>
public sealed class PlanItem
{
    public PlanItem(string task) => Task = task;

    public string Task { get; }
    public bool Done { get; set; }
}

/// <summary>
/// A ReAct planner that gives the model two tools to keep its own plan: <c>update_plan</c> and
/// <c>mark_done</c>. Chapter 6.
/// </summary>
public class PlanAndSolve : ReAct
{
    public PlanAndSolve(Tools tools, int maxSteps = 10) : base(maxSteps)
    {
        throw new NotImplementedException("Chapter 6: PlanAndSolve.constructor. See chapters/Chapter06/README.md");
    }

    public List<PlanItem> Plan { get; private set; } = [];

    public override string Prompt
    {
        get
        {
            throw new NotImplementedException("Chapter 6: PlanAndSolve.Prompt. See chapters/Chapter06/README.md");
        }
    }

    /// <summary>Replace the plan with new sub-tasks, none of them done.</summary>
    [Description("Create or overwrite the plan with a list of sub-tasks.")]
    public string UpdatePlan(List<string> items)
    {
        throw new NotImplementedException("Chapter 6: PlanAndSolve.UpdatePlan. See chapters/Chapter06/README.md");
    }

    /// <summary>Mark a sub-task done, counting from 1.</summary>
    [Description("Mark a sub-task complete by 1-based index.")]
    public string MarkDone(int index)
    {
        throw new NotImplementedException("Chapter 6: PlanAndSolve.MarkDone. See chapters/Chapter06/README.md");
    }

    /// <summary>The plan as a checklist: <c>[x] 1. Task</c> or <c>[ ] 2. Task</c>, one per line.</summary>
    public string Render()
    {
        throw new NotImplementedException("Chapter 6: PlanAndSolve.Render. See chapters/Chapter06/README.md");
    }
}

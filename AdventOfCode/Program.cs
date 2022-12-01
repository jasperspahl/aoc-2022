switch (args.Length)
{
    case 0:
        await Solver.SolveLast(opt => opt.ClearConsole = false);
        break;
    case 1 when args[0].Contains("all", StringComparison.CurrentCultureIgnoreCase):
        await Solver.SolveAll(opt =>
        {
            opt.ShowConstructorElapsedTime = true;
            opt.ShowTotalElapsedTimePerDay = true;
        });
        break;
    default:
    {
        var indexes = args.Select(arg => uint.TryParse(arg, out var index) ? index : uint.MaxValue);

        await Solver.Solve(indexes.Where(i => i < uint.MaxValue));
        break;
    }
}

using System.Diagnostics;
using System.Threading.Tasks;
using Xunit;

namespace AdventOfCode.Tests;

public class Day03Test
{
    private readonly Day03 _sub;

    public Day03Test()
    {
        var testInput = "vJrwpWtwJgWrhcsFMMfFFhFp\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\nPmmdzqPrVvPwwTWBwg\nwMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\nttgJtRGJQctTZtZT\nCrZsJsPPZsGzwwsLwLmpwMDw";
        _sub = new Day03(testInput);
    }

    [Fact]
    public async Task TestPart1()
    {
        var result = await _sub.Solve_1();
        Debug.Assert(result != null, nameof(result) + " != null");
        Assert.True(result == "157");
    }
    [Fact]
    public async Task TestPart2()
    {
        var result = await _sub.Solve_2();
        Debug.Assert(result != null, nameof(result) + " != null");
        Assert.True(result == "70");
    }
}
using Xunit.Abstractions;

namespace AdventOfCode2025.Day01Puzzle01;

public class Runner(ITestOutputHelper testOutputHelper)
{
  [Fact]
  public async Task CalculateTimesHitting0()
  {
    SafeDial dial = new(50, 99);

    string[] lines = await File.ReadAllLinesAsync("Day01Puzzle01\\input.txt");
    foreach (string line in lines)
    {
      int ticks = int.Parse(line[1..]);
      if (line.StartsWith("L")) dial.MoveLeft(ticks);
      if (line.StartsWith("R")) dial.MoveRight(ticks);
    }
    
    testOutputHelper.WriteLine(dial.TimesHitting0.ToString());
  }
}
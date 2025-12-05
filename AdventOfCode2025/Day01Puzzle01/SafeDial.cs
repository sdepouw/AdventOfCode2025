namespace AdventOfCode2025.Day01Puzzle01;

public class SafeDial(int startingPosition, int maxPosition)
{
  private int _position = startingPosition;
  public int TimesHitting0;
  
  public void MoveLeft(int ticks)
  {
    for (int i = 0; i < ticks; i++)
    {
      _position--;
      if (_position < 0) _position = maxPosition;
    }
    if (_position == 0) TimesHitting0++;
  }

  public void MoveRight(int ticks)
  {
    for (int i = 0; i < ticks; i++)
    {
      _position++;
      if (_position > maxPosition) _position = 0;
    }
    if (_position == 0) TimesHitting0++;
  }
}

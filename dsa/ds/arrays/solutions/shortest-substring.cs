/* - PROBLEM STATEMENT -
Given a string and a set of characters print the shortest substring that contains all the given characters.

Example 1:

Input:
Sample = "I am with nature"
Characters = "aim"
Output: I am

Example 2:

Input:
Sample = "You are love"
Characters = "rvo"
Output: ou are lov

- PROBLEM STATEMENT - */
namespace dsa.ds.arrays.solutions
{
  public class ShortestSubstring : ISolution
  {
    public string Name => "Shortest Substring";

    public void Run()
    {
      var example1 = new
      {
        sample = "I am with nature",
        characters = "aim"
      };

      var example2 = new
      {
        sample = "You are love",
        characters = "rvo"
      };

      var input = example2;

      var firstIndex = -1;
      var lastIndex = -1;

      for (var x = 0; x < input.sample.Length; x++)
      {
        if (input.characters.IndexOf(input.sample[x]) == -1)
        {
          continue;
        }

        if (firstIndex == -1)
        {
          firstIndex = x;

        }
        else if (lastIndex == -1 || lastIndex < x)
        {
          lastIndex = x;
        }
      }

      if (lastIndex == -1)
      {
        lastIndex = firstIndex;
      }

      Console.WriteLine(input.sample.Substring(firstIndex, lastIndex - firstIndex + 1));
    }
  }
}
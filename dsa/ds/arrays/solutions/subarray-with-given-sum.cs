/* - PROBLEM STATEMENT -
Given an unsorted array A of size N that contains only non-negative integers, find a continuous sub-array which adds to a given number S.

Example 1:

Input:
N = 5, S = 12
A[] = {1,2,3,7,5}
Output: 2 4
Explanation: The sum of elements
from 2nd position to 4th position
is 12.

11
9
6
-1

Example 2:

Input:
N = 10, S = 15
A[] = {1,2,3,4,5,6,7,8,9,10}
Output: 1 5
Explanation: The sum of elements
from 1st position to 5th position
is 15.

Your Task:
You don't need to read input or print anything. The task is to complete the function subarraySum() which takes arr, N and S as input parameters and returns a list containing the starting and ending positions of the first such occurring subarray from the left where sum equals to S. The two indexes in the list should be according to 1-based indexing. If no such subarray is found, return an array consisting only one element that is -1.

Expected Time Complexity: O(N)
Expected Auxiliary Space: O(1)

Constraints:
1 <= N <= 105
1 <= Ai <= 109

- PROBLEM STATEMENT - */
namespace dsa.ds.arrays.solutions
{
  public class SubArrayWithGivenSum : ISolution
  {
    public string Name => "Subarray with given sum";

    public async void Run()
    {
      var example1 = new
      {
        size = 5,
        array = new List<int> { 1, 2, 3, 7, 5 },
        sum = 12
      };

      var example2 = new
      {
        size = 10,
        array = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
        sum = 15
      };

      var example3 = new
      {
        size = 57,
        array = new List<int> { 28, 68, 142, 130, 41, 14, 175, 2, 78, 16, 84, 14, 193, 25, 2, 193, 160, 71, 29, 28, 85, 76, 187, 99, 171, 88, 48, 5, 104, 22, 64, 107, 164, 11, 172, 90, 41, 165, 143, 20, 114, 192, 105, 19, 33, 151, 6, 176, 140, 104, 23, 99, 48, 185, 49, 172, 65 },
        sum = 1562
      };

      var input = example3.array;
      var size = example3.size;
      var sum = example3.sum;
      var sumArray = new List<int>();
      var firstIndex = 0;
      var index = 0;

      // solution 1
      while (index < size || firstIndex <= index)
      {
        if (index < size)
        {
          sum -= input[index];
          index++;
        }

        if (sum < 0)
        {
          sum += input[firstIndex];
          firstIndex += 1;
        }
        else if (index >= size)
        {
          firstIndex += 1;
        }

        if (sum == 0)
        {
          Console.WriteLine($"{firstIndex + 1} {index}");
          break;
        }

        if (index >= size && sum > 0)
        {
          break;
        }

      }

      if (sum != 0)
      {
        Console.WriteLine($"Not found! {sum} {firstIndex} {index}");
      }

      /* solution 2

      for (var index = 0; index < input.Count; index++)
      {
        for (var sumIndex = 0; sumIndex < sumArray.Count; sumIndex++)
        {
          sumArray[sumIndex] += input[index];

          if (sumArray[sumIndex] == sum)
          {
            firstIndex = sumIndex;
            lastIndex = index;

            break;
          }
        }

        if (firstIndex != -1)
        {
          break;
        }

        if (input[index] == sum)
        {
          firstIndex = index;
          lastIndex = index;

          break;
        }

        sumArray.Add(input[index]);
      }

      Console.WriteLine($"{firstIndex + 1} {lastIndex + 1}");

      */
    }
  }
}
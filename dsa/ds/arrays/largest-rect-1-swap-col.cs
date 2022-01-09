/* - PROBLEM STATEMENT -
Largest rectangle of 1s with swapping of columns allowed

Given a matrix mat of size R*C with 0 and 1’s, find the largest rectangle of all 1’s in the matrix. The rectangle can be formed by swapping any pair of columns of given matrix.

Example 1:

Input:
R = 3, C = 5
mat[][] = {{0, 1, 0, 1, 0},
           {0, 1, 0, 1, 1},
           {1, 1, 0, 1, 0}};
Output: 6
Explanation: The largest rectangle's area
is 6. The rectangle can be formed by
swapping column  2 with 3. The matrix
after swapping will be
     0 0 1 1 0
     0 0 1 1 1
     1 0 1 1 0

Example 2:

Input:
R = 4, C = 5
mat[][] = {{0, 1, 0, 1, 0},
           {0, 1, 1, 1, 1},
           {1, 1, 1, 0, 1},
           {1, 1, 1, 1, 1}};
Output: 9
Your Task:
You don't need to read input or print anything. Your task is to complete the function maxArea() which takes the 2D array of booleans mat, r and c as parameters and returns an integer denoting the answer.

Expected Time Complexity: O(R*(R + C))
Expected Auxiliary Space: O(R*C)

Constraints:
1<= R,C <=103
0 <= mat[i][j] <= 1

- PROBLEM STATEMENT - */
namespace dsa.ds.arrays
{
  public class LargestRect1SwapCol : ISolution
  {
    public string Name => "Largest rectangle of 1s with swapping of columns allowed";

    public void Run()
    {
      var example1 = new List<List<int>> {
        new List<int>{0, 1, 0, 1, 0},
        new List<int>{0, 1, 0, 1, 1},
        new List<int>{1, 1, 0, 1, 0}
      };

      var example2 = new List<List<int>> {
        new List<int>{0, 1, 0, 1, 0},
        new List<int>{0, 1, 1, 1, 1},
        new List<int>{1, 1, 1, 0, 1},
        new List<int>{1, 1, 1, 1, 1}
      };

      var input = example2;
      var numberOfColumns = input[0].Count;
      var numberOfRows = input.Count;

      // APPROACH 1
      var indicesOfFilledColumns = new List<int>();

      for (int i = 0; i < numberOfColumns; i++)
      {
        if (input[0][i] == 1)
        {
          var isFilled = true;
          for (int j = 0; j < numberOfRows; j++)
          {
            if (input[j][i] == 0)
            {
              isFilled = false;

              break;
            }
          }

          if (isFilled)
          {
            indicesOfFilledColumns.Add(i);
          }
        }
      }

      Console.WriteLine($"Area: { indicesOfFilledColumns.Count * numberOfRows }");

      // APPROACH 2

      // STEP 1: Find TOP-LEFT & BOTTOM-RIGHT corner (TL,BR)
      //          for each x(i); TOP-LEFT: 1 <= i < no.of.columns
      //                          BOTTOM-RIGHT: 0 <= i < no.of.columns

      // STEP 2: For-each point (x,y) check if the point falls under a pair of (TL,BR)
    }
  }
}
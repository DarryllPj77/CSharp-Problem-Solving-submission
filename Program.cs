using System.Timers;

namespace LeetCodeSolutions
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Solutions solutions = new Solutions(); // no need since i use static methods
            #region -- Count Even Numbers --
            // Input:  numbers = [2, 5, 8, 11, 14]
            // Output: 3
            int[] exampleNum1 = { 2, 5, 8, 11, 14 };

            int result1 = Solutions.CountEvenNumbers(exampleNum1);

            Console.WriteLine("Level 1: Count Even Numbers: " + result1);
            /*
             4. Complexity Analysis
                - Time: O(n) — You visit each array element once.
                - Space: O(1) — You only create one additional variable, count.
             */
            #endregion


            #region -- Count Numbers Greater Than 10 --
            int[] exampleNum2 = { 5, 12, 8, 20, 15, 3 };

            int result2 = Solutions.CountNumberGreaterThanTen(exampleNum2);
            Console.WriteLine("Level 2: Count Numbers Greater Than 10: " + result2);
            // Complexity:
            // - Time: O(n)
            // - Space: O(1)
            #endregion

            #region -- Sum of Even Numbers --
            int[] exampleNum3 = { 3, 4, 7, 8, 10, 5 };

            int result3 = Solutions.SumOfEvenNumbers(exampleNum3);
            Console.WriteLine("Level 3: Sum of Even Numbers: " + result3);

            // Complexity: O(n) time, O(1) extra space.

            #endregion

            #region -- Find the Largest Number -- 

            int[] exampleNum4 = { 4, 12, 7, 25, 9, 17 };

            int result4 = Solutions.FindTheLargestNumber(exampleNum4);
            Console.WriteLine("Level 4: Find the Largest Number: " + result4);

            //Complexity:
            // - Time: O(n)
            // - Space: O(1)

            #endregion

            #region -- Find the Smallest Number --
            int[] exampleNum5 = { 15, 8, 23, 4, 12, 9 };

            int result5 = Solutions.FindTheSmallNumber(exampleNum5);

            Console.WriteLine("Level 5: Find the Smallest Number: " + result5);

            // Complexity: O(n) time, O(1) extra space.
            #endregion

            #region -- Level 6: Count Positive and Negative Numbers --

            int[] exampleNum6 = { -3, 5, 0, -1, 8, -7, 4 };

            (int result6Positive, int result6Negative) = Solutions.CountPositiveAndNegativeNum(exampleNum6);

            Console.WriteLine("Level 6: Count Positive and Negative Numbers: " + (result6Positive,result6Negative));

            // Complexity: O(n) time, O(1) extra space.

            #endregion

            #region -- Count Occurrences of a Number --

            int[] exampleNum7 = { 3, 5, 3, 8, 9, 5 };

            int result7 = Solutions.CountOccurrencesOfNum(exampleNum7);
            Console.WriteLine("Level 7: Count Occurrences of a Number: " + result7);


            #endregion

            #region -- Find the First Occurrence --

            int[] exampleNum8 = { 5, 8, 3, 9, 3, 7 };

            int result8 = Solutions.FindTheFirstOccurrence(exampleNum8);
            Console.WriteLine("Level 8: Find the First Occurrence: " + result8 + " element value: " + exampleNum8[result8]);


            #endregion
        }
    }
}

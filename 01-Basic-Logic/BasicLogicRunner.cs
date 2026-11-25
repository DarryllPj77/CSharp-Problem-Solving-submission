using System.Diagnostics.Metrics;
using System.Timers;

namespace LeetCodeSolutions
{
    public static class BasicLogicRunner
    {
        public static void Run()
        {
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

            // Complexity: O(n) time, O(1) extra space.

            #endregion

            #region -- Find the First Occurrence --

            int[] exampleNum8 = { 5, 8, 3, 9, 3, 7 };

            int result8 = Solutions.FindTheFirstOccurrence(exampleNum8);
            Console.WriteLine("Level 8: Find the First Occurrence: " + result8 + " element value: " + exampleNum8[result8]);

            // Time: O(n) worst case; O(1) best case.
            // Space: O(1).

            #endregion

            #region -- Level 9: Find the Last Occurrence -- 

            int[] exampleNum9 = { 5, 3, 8, 3, 9, 3, 7 };

            int result9 = Solutions.FindTheLastOccurrence(exampleNum9);
            Console.WriteLine("Level 9: Find the Last Occurrence: " + result9);

            //Time: O(n) — Every element is checked.
            //Space: O(1) — Only a few variables are stored.

            #endregion

            #region -- Level 10: Count Numbers Greater Than the Average --

            int[] exampleNum10 = { 2, 4, 6, 8, 10 };

            int result10 = Solutions.CountNumbersGreaterThanAverage(exampleNum10);
            Console.WriteLine("Level 10: Count Numbers Greater Than the Average: " + result10);

            // Complexity
            // -Time: O(n) — Two separate loops, each traversing the array.
            // -Space: O(1) — Only a few variables.

            #endregion


            #region -- Level 11: Count Adjacent Equal Numbers -- 

            int[] exampleNum11 = { 2, 2, 5, 5, 5, 8, 3, 3 };
            int result11 = Solutions.CountAdjacentEqualNumbers(exampleNum11);
            Console.WriteLine("Level 11: Count Adjacent Equal Numbers: " + result11);

            // Complexity:
            // - Time: O(n)
            // - Space: O(1)

            #endregion

            #region -- Level 12: Count Increasing Adjacent Pairs --
            int[] exampleNum12 = { 2, 5, 3, 7, 9, 4, 8 };
            int result12 = Solutions.CountIncreasingAdjacentPairs(exampleNum12);
            Console.WriteLine("Level 12: Count Increasing Adjacent Pairs: " + result12);

            // Complexity Analysis
            // -Time: O(n) — Each neighboring pair is compared once.
            // -Space: O(1) — Only one counter variable is used.
            #endregion
        }
    }
}

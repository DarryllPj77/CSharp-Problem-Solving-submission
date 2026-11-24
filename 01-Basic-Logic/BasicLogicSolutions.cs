namespace LeetCodeSolutions
{
    public class Solutions
    {
        public static int CountEvenNumbers(int[] numbers)
        {
            // Your task is to count how many even numbers exist in the array.
            // Input:  numbers = [2, 5, 8, 11, 14]
            // Output: 3
            int count = 0;

            foreach (int num in numbers)
            {
                if(num % 2 == 0) //even
                {
                    count++;
                }
            }

            return count;
        }

        public static int CountNumberGreaterThanTen(int[] numbers)
        {
            // Problem: Given an integer array, return how many numbers are greater than 10.
            // Input:  [5, 12, 8, 20, 15, 3]
            // Output: 3

            int count = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 10)
                {
                    count++;
                }
            }

            return count;
        }

        public static int SumOfEvenNumbers(int[] numbers)
        {
            // Input:  [3, 4, 7, 8, 10, 5]
            // Output: 22

            int sum = 0;

            foreach (var num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }

        public static int FindTheLargestNumber(int[] numbers)
        {
            // Input: [4, 12, 7, 25, 9, 18]
            // Output: 25
            int maxNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }

        public static int FindTheSmallNumber(int[] numbers)
        {
            int minNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            return minNumber;
        }

        public static (int positive, int negative) CountPositiveAndNegativeNum(int[] numbers)
        {
            int positiveCount = 0;
            int negativeCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positiveCount++;
                }
                else if (numbers[i] < 0)
                {
                    negativeCount++;
                }
            }

            return (positiveCount, negativeCount);
        }

        public static int CountOccurrencesOfNum(int[] numbers)
        {
            int target = 3;
            int targetCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    targetCount++;
                }
            }

            return targetCount;
        }

        public static int FindTheFirstOccurrence(int[] numbers)
        {
            int target = 3;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int FindTheLastOccurrence(int[] numbers)
        {
            //  i =      0  1  2  3  4  5  6  index visualizer
            //numbers = [5, 3, 8, 3, 9, 3, 7]
            int target = 3;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    lastIndex = i;
                }
            }

            return lastIndex;
        }

        public static int CountNumbersGreaterThanAverage(int[] numbers)
        {
            int average = 0;
            int sum = 0;
            int count = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }

            average = sum / numbers.Length;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > average)
                {
                    count++;
                }
            }

            return count;
        }


    }
}

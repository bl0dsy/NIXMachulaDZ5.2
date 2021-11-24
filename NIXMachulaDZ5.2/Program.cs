using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIXMachulaDZ5._2
{
    using System;

    class Program
    {

        static void calculations(int[] nums, out int oddSum, out int count)
        {
            int cnt = 0;
            int ods = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0 && nums[i] != 0)
                {
                    //Console.WriteLine(nums[i]);
                    cnt++;
                }
                else
                {
                    ods = ods + nums[i];
                }
            }
            oddSum = ods;
            count = cnt;
        }

        public static int[] calculate(int rows, int[][] arr)
        {
            int i = 0;

            int max = 0;
            int[] result = new int[rows];
            while (i < rows)
            {
                for (int j = 0;
                         j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                    }
                }
                result[i] = max;
                max = 0;
                i++;

            }
            return result;

        }

        public static int[] calculateMin (int rows, int[][] arr)
        {
            int i = 0;


            int[] result = new int[rows];
            while (i < rows)
            {
                int min = arr[i][0];
                for (int j = 0;
                         j < arr[i].Length; j++)
                {
                    if (arr[i][j] < min)
                    {
                        min = arr[i][j];
                    }
                }
                result[i] = min;
                min = 0;
                i++;

            }
            return result;

        }

        static void Main (string[] args)
        {
            int[] nums = { 6, 2, 1, 5, 0, 6, 5, 4, 3, 7 };
            calculations(nums, out int os, out int cnt);
            Console.WriteLine(cnt);
            Console.WriteLine(os);

            int[][] arr = new int[][]
            {
        new int[] { 2, 4, 3, 1 },
        new int[] { 3, 5, 4, 2 },
        new int[] { 6, 1, 5, 7 },
        new int[] { 8, 2, 4, 9 } };

            int[] task2 = calculate(4, arr);
            int[] task3 = calculateMin(4, arr);

            Console.WriteLine("Task 2: ");
            foreach (int display in task2)
            {
                Console.WriteLine(display);
            }
            Console.WriteLine("Task 3: ");
            foreach (int display in task3)
            {
                Console.WriteLine(display);
            }
        }

    }
}
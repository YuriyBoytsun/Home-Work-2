using System;

namespace Home_Work_2._1
{
    class Program
    {
        static void Ask()
        {
            int[] nums = new int[3];
            int i = 0;
            for (i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("add a number");
                nums[i] = Convert.ToInt32(Console.ReadLine());

            }
            Result(nums);
        }

        static void Result(int[] nums)
        {
            int result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (result > nums[i]) result = nums[i];
                else continue;
            }
            Console.WriteLine($"resuit is {result}");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Ask();
        }
    }
}



using System.Collections.Immutable;

namespace Challengelab6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] nums = { 3, 0, 1 };
            int missingNumber = MissingNumber(nums);
            Console.WriteLine(missingNumber);
		}
		static int MissingNumber(int[] nums)
        {
			// [3, 0, 1]
			// There are 3 numbers so starting from 1 :  0 1 2 3
			// Since 3 0 and 1 are already showing the missing number would be 2
			Array.Sort(nums);
            for (int i = 0; i<nums.Length; i++)
            {
                if (i != nums[i])
                {
                    return i;
                }
            }
            return nums.Length;
       }
	}
}

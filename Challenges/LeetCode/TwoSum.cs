namespace Challenges.LeetCode
{
    public class TwoSum : IChallenge
    {
        public void Execute()
        {
            var result = Sum(new int[] { 2, 7, 11, 15 }, 9);
            var result1 = Sum(new int[] { 3, 2, 4 }, 6);
            var result2 = Sum(new int[] { 3, 3 }, 6);
            var result3 = Sum(new int[] { 2, 5, 5, 11 }, 10);

            Console.WriteLine(result.SequenceEqual(new int[] { 0, 1 }));
            Console.WriteLine(result1.SequenceEqual(new int[] { 1, 2 }));
            Console.WriteLine(result2.SequenceEqual(new int[] { 0, 1 }));
            Console.WriteLine(result3.SequenceEqual(new int[] { 1, 2 }));
        }

        public int[] Sum(int[] nums, int target)
        {
            var result = new int[2];
            
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (i != j && nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
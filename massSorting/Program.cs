
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        String[] strings = Console.ReadLine().Split(" ");
        int[] nums = new int[strings.Length];
        for (int i = 0;i<strings.Length;i++)
        {
            nums[i] = Convert.ToInt32(strings[i]);
        }
        sort(nums);
    }
    private static void sort(int[] nums)
    {
        int temp = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if ((i+1!=nums.Length) && nums[i] > nums[i + 1])
            {
                temp = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = temp;
                i = -1;
                foreach(int number in nums)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
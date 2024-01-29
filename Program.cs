class Program
{
    static void Main(String[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 44, 6, 6, 6, 28, 43, 48, 47, 46, 24, 13, 19, 17, 23, 35 };

        int target = 50;


        FindThreeNumbers(arr, target);


    }


    static void FindThreeNumbers(int[] nums, int target)
    {
        var s = new HashSet<int>();
        int count = 0;

        foreach (var i in nums)
        {
            List<int> ints = new List<int>();
            ints = nums.Skip(count).ToList();
            count++;

            foreach (var item in ints)
            {
                var x = target - item - i;
                if (s.Contains(x))
                {
                    if(i.GetHashCode() != item.GetHashCode())
                    Console.WriteLine($"{x} + {i} + {item}");
                }
                else
                    s.Add(i);
            }


        }
    }
}

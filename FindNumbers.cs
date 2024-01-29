public class FindNumbers
{
    public void FindThreeNumbers1(int[] nums, int target)
    {
        var s = new HashSet<int>();

        foreach (var i in nums)
        {
            var x = target - i;
            if (s.Contains(x))
            {
                Console.WriteLine($"{x} + {i}");
            }
            else
                s.Add(i);
        }
    }
}



class Program
{ 
    static void Main(string[] args)
    { 
        var solution1342 =  new Solution1342();
        var answer1342 = solution1342.NumberOfSteps(14);
        Console.WriteLine(answer1342);

        var solution2413 =  new Solution2413();
        var answer2413 = solution2413.SmallestEvenMultiple(5);
        Console.WriteLine(answer2413);

        var solution2235 =  new Solution2235();
        var answer2235 = solution2235.Sum(12,5);
        Console.WriteLine(answer2235);

        var solution1365 =  new Solution1365();
        int[] nums = new int[] { 6, 5, 4, 8};
        var answer1365 = solution1365.SmallerNumbersThanCurrent(nums);
        Console.WriteLine(answer1365);

        var solution1480 =  new Solution1480();
        int[] numbers = new int[] { 6, 5, 4, 8};
        var answer1480 = solution1480.RunningSum(numbers);
        Console.WriteLine(answer1365);

        

    }
}

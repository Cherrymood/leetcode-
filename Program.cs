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

        var solution771 =  new Solution771();
        string jewels = "aA";
        string stones = "aAAbbbb";
        var answer771 = solution771.NumJewelsInStones(jewels, stones);
        Console.WriteLine(answer771);

        var solution509 =  new Solution509();
        int n = 5;
        var answer509 = solution509.Fib(n);
        Console.WriteLine(answer509);

        var solution1689 = new Solution1689();
        string m = "32";
        var answer1689 = solution1689.MinPartitions(m);
        Console.WriteLine(answer1689);

        var solution2574 = new Solution2574();
        int[] nums2574 = {10,4,8,3};
        var answer2574 = solution2574.LeftRigthDifference(nums2574);
        Console.WriteLine(answer1689);

        var solution1389 = new Solution1389();
        int[] nums1389 = {0,1,2,3,4 };
        int[] index1389 = {0,1,2,2,1};
        var answer1389 = solution1389.CreateTargetArray(nums1389, index1389);
        Console.WriteLine(answer1389);

        var solution2652 = new Solution2652();
        int num2652 = 10;
        var answer2652 = solution2652.SumOfMultiples(num2652);
        Console.WriteLine(answer2652);

        var solution1816 = new Solution1816();
        var s1816 = "Hello how are you Contestant";
        var k1816 = 3;
        var answer1816 = solution1816.TruncateSentence(s1816, k1816);
        Console.WriteLine(answer1816);

        var solution2656 = new Solution2656();
        var nums2656 = new int[] {1,2,3,4,5};
        var k2656 = 3;
        var answer2656 = solution2656.MaximizeSum(nums2656, k2656);
        Console.WriteLine(answer2656);

        var solution2006 = new Solution2006();
        var nums2006 = new int[] {1,2,2,1};
        var k2006 = 1;
        var answer2006 = solution2006.CountKDifference(nums2006, k2006);
        Console.WriteLine(answer2006);

        var solution1684 = new Solution1684();
        var allowed = "ab";
        var words1684 = new string[] {"ad","bd","aaab","baa","badab"};
        var answer1684 = solution1684.CountConsistentStrings(allowed, words1684);
        Console.WriteLine(answer1684);

        var solution1913 = new Solution1913();
        var nums1913 = new int[] {5,6,2,7,4};
        var answer1913 = solution1913.MaxProductDifference(nums);
        Console.WriteLine(answer1913);

        var solution1464 = new Solution1464();
        var nums1464 = new int[] {5,6,2,7,4};
        var answer1464 = solution1464.MaxProduct(nums1464);
        Console.WriteLine(answer1464);

        var solution1534 = new Solution1534();
        var nums1534 = new int[] {3,0,1,1,9,7};
        var a1534 = 7;
        var b1534 = 2;
        var c1534 = 1;
        var answer1534 = solution1534.CountGoodTriplets(nums1534, a1534, b1534, c1534);
        Console.WriteLine(answer1534);

        var solution2367 = new Solution2367();
        var nums2367 = new int[] {0,1,4,6,7,10};
        var diff2367 = 3;
        var answer2367 = solution2367.ArithmeticTriplets(nums2367, diff2367);
        Console.WriteLine(answer2367);

        var solution2500 = new Solution2500();
        var nums2500 = new int[2][]{
                new int[3]{1, 2, 3},
                new int[4]{4, 5, 6, 7}};
        var answer2500 = solution2500.DeleteGreatestValue(nums2500);
        Console.WriteLine(answer2500);

        var solution2545 = new Solution2545();
        var nums2545 = new int[3][]{
                new int[4]{1, 2, 3, 4},
                new int[4]{4, 5, 6, 6},
                new int[4]{7, 9, 5, 0}};
        var k2545 = 0;
        var answer2545 = solution2545.SortTheStudents(nums2545, k2545);
        Console.WriteLine(answer2545);

        var solution832 = new Solution832();
        var nums832 = new int[3][]{
                new int[3]{1, 1, 0},
                new int[3]{0, 0, 1},
                new int[3]{1, 1, 0}};
        var answer832 = solution832.FlipAndInvertImage(nums832);
        Console.WriteLine(answer832);

        var solution1630 = new Solution1630();
        var nums1630 = new int[] {4,6,5,9,3,7};
        var l1630  = new int[] {0, 0, 2};
        var r1630 = new int[]   {2, 3, 5};
        var answer1630 = solution1630.CheckArithmeticSubarrays(nums1630, l1630, r1630);
        Console.WriteLine(answer1630);

        
        /*
        int[][] rectungle = [1,2,1] [4,3,4] [3,2,1] [1,1,1];
        var subrectangleQueries = new SubrectangleQueries(rectungle);
        subrectangleQueries.UpdateSubrectangle(2, 3, 4, 5, 66);
        subrectangleQueries.GetValue(0, 2);
        */




        

    }
}

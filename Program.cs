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

        var solution1768 = new Solution1768();
        var word1768 = "abcd";
        var word21768  = "pq";
        var answer1768 = solution1768.MergeAlternately(word1768, word21768);
        Console.WriteLine(answer1768);

        var solution605 = new Solution605();
        var num605 = new int[] {1,0,0,0,0,1};
        var n605  = 2;
        var answer605 = solution605.CanPlaceFlowers(num605, n605);
        Console.WriteLine(answer605);

        var solution151 = new Solution151();
        var s151 = "  Bob    Loves  Alice   ";
        var answer151 = solution151.ReverseWords(s151);
        Console.WriteLine(answer151);

        var solution1071 = new Solution1071();
        var s11071 = "ABABAB" ;
        var s21071 = "ABAB";
        var answer1071 = solution1071.GcdOfStrings(s11071, s21071);
        Console.WriteLine(answer1071);

        var solution345 = new Solution345();
        var s345 = "Hello" ;
        var answer345 = solution345.ReverseVowels(s345);
        Console.WriteLine(answer345);

        var solution398 = new Solution398();
        var s398 = "abc";
        var t398 = "ahbgdc";
        var answer398 = solution398.IsSubsequence(s398, t398);
        Console.WriteLine(answer398);

        var solution238 = new Solution238();
        var nums238 = new int[] {1,2,3,4};
        var answer238= solution238.ProductExceptSelf(nums238);
        Console.WriteLine(answer238);

        var solution724 = new Solution724();
        var nums724 = new int[] {1,7,3,6,5,6};
        var answer724= solution724.PivotIndex(nums724);
        Console.WriteLine(answer724);

        var solution334 = new Solution334();
        var nums334 = new int[] {2,1,5,0,6,7};
        var answer334= solution334.IncreasingTriplet(nums334);
        Console.WriteLine(answer334);

        var solution2930 = new Solution2390();
        var s2930 = "leet**cod*e";
        var answer2930= solution2930.RemoveStars(s2930);
        Console.WriteLine(answer2930);

        var solution2215 = new Solution2215();
        var nums12215 = new int[] {1,7,3,6};
        var nums22215 = new int[] {6,5,6};
        var answer2215= solution2215.FindDifference(nums12215, nums22215);
        Console.WriteLine(answer2215);

        var solution643 = new Solution643();
        var nums643 = new int[] {1,12,-5,-6,50,3};
        var k643 = 4;
        var answer643= solution643.FindMaxAverage(nums643, k643);
        Console.WriteLine(answer643);

        var solution1456 = new Solution1456();
        var s1456 = "abciiidef";
        var k1456 = 3;
        var answer1456= solution1456.MaxVowels(s1456, k1456);
        Console.WriteLine(answer1456);

        var solution1732 = new Solution1732();
        var gain1732 = new int[] {1,7,3,6};
        var answer1732= solution1732.LargestAltitude(gain1732);
        Console.WriteLine(answer1732);

        var solution443 = new Solution443();
        var chars443 = new char[] {'a','a','b','b','c','c','c'};
        var answer443= solution443.Compress(chars443);
        Console.WriteLine(answer443);

        var solution219 = new Solution219();
        var nums219 = new int[] {1,2,3,1,2,3};
        var k219 = 2;
        var answer219= solution219.ContainsNearbyDuplicate(nums219, k219);
        Console.WriteLine(answer219);

        var solution2269 = new Solution2269();
        var num2269 = 430043;
        var k2269 = 2;
        var answer2269 = solution2269.DivisorSubstrings(num2269, k2269);
        Console.WriteLine(answer2269);

        var solution1876 = new Solution1876();
        var s1876 = "xyzzaz";
        var answer1876 = solution1876.CountGoodSubstrings(s1876);
        Console.WriteLine(answer1876);

        var solution2760 = new Solution2760();
        var nums2760 = new int[] {2,7};
        var threshold2760 = 9;
        var answer2760 = solution2760.LongestAlternatingSubarray(nums2760, threshold2760);
        Console.WriteLine(answer2760);

        var solution1343 = new Solution1343();
        var nums1343 = new int[] {2,2,2,2,5,5,5,8};
        var threshold1343 = 4;
        var k1343 = 3;
        var answer1343 = solution1343.NumOfSubarrays(nums1343, k1343, threshold1343);
        Console.WriteLine(answer1343);

        var solution2024 = new Solution2024();
        var answerKey2024 = "TFFT";
        var k2024 = 1;
        var answer2024 = solution2024.MaxConsecutiveAnswers(answerKey2024, k2024);
        Console.WriteLine(answer2024);

        var solution1493 = new Solution1493();
        var nums1493 = new int[] {1,1,0,1};
        var answer1493 = solution1493.LongestSubarray(nums1493);
        Console.WriteLine(answer1493);

        var solution1358 = new Solution1358();
        var s1358 = "aaaabc";
        var answer1358 = solution1358.NumberOfSubstrings(s1358);
        Console.WriteLine(answer1358);

        var solution3 = new Solution3 ();
        var s3 = "abcabcbb";
        var answer3 = solution3.LengthOfLongestSubstring(s3);
        Console.WriteLine(answer3);

        var solution413 = new Solution413 ();
        var nums413 = new int[] {1,2,3,4};
        var answer413 = solution413.NumberOfArithmeticSlices(nums413);
        Console.WriteLine(answer413);

        var solution1052 = new Solution1052 ();
        var customers1052 = new int[] {1,0,1,2,1,1,7,5};
        var grumpy1052 = new int[] {0,1,0,1,0,1,0,1};
        var minutes1052 = 3;
        var answer1052 = solution1052.MaxSatisfied(customers1052, grumpy1052, minutes1052);
        Console.WriteLine(answer1052);

        var solution11 = new Solution11 ();
        var nums11 = new int[] {1,8,6,2,5,4,8,3,7};
        var answer11 = solution11.MaxArea(nums11);
        Console.WriteLine(answer11);

        var solution1679 = new Solution1679 ();
        var nums1679 = new int[] {1,2,3,4};
        var k1679 = 5;
        var answer1679 = solution1679.MaxOperations(nums1679, k1679);
        Console.WriteLine(answer1679);

        var solution1004 = new Solution1004 ();
        var nums1004 = new int[] {0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1};
        var k1004 = 3;
        var answer1004 = solution1004.LongestOnes(nums1004, k1004);
        Console.WriteLine(answer1004);

        var solution1207 = new Solution1207 ();
        var arr1207 = new int[] {1,2,2,1,1,3};
        var answer1207 = solution1207.UniqueOccurrences(arr1207);
        Console.WriteLine(answer1207);

        var solution1657 = new Solution1657 ();
        var word11657 = "cabbba";
        var word21657 = "abbccc";
        var answer1657 = solution1657.CloseStrings(word11657, word21657);
        Console.WriteLine(answer1657);

        var solution2352 = new Solution2352 ();
        var grid2352 = new int[][] {
                new int[10]{3, 3, 3, 6, 18, 3, 3, 3, 3, 3},
                new int[10]{3,3,3,3,1,3,3,3,3,3},
                new int[10]{3,3,3,3,1,3,3,3,3,3},
                new int[10]{3,3,3,3,1,3,3,3,3,3},
                new int[10]{1,1,1,11,19,1,1,1,1,1},
                new int[10]{3,3,3,18,19,3,3,3,3,3},
                new int[10]{3,3,3,3,1,3,3,3,3,3},
                new int[10]{3,3,3,3,1,3,3,3,3,3},
                new int[10]{3,3,3,1,6,3,3,3,3,3},
                new int[10]{3,3,3,3,1,3,3,3,3,3}
                };
        var answer2352 = solution2352.EqualPairs(grid2352);
        Console.WriteLine(answer2352);

        var solution735 = new Solution735 ();
        var arr735 = new int[] {-2,-1,1,2};
        var answer735 = solution735.AsteroidCollision(arr735);
        Console.WriteLine(answer735);

        var solution402 = new Solution402 ();
        var num402 = "1432219";
        var k402 = 3;
        var answer402 = solution402.RemoveKdigits(num402, k402);
        Console.WriteLine(answer402);

        var solution921 = new Solution921 ();
        var s921 = "))())";
        var answer921 = solution921.MinAddToMakeValid(s921);
        Console.WriteLine(answer921);

        var solution1441 = new Solution1441 ();
        var target1441 = new int[] {1, 3};
        var n1441 = 3;
        var answer1441 = solution1441.BuildArray(target1441, n1441);
        Console.WriteLine(answer1441);

        var solution1249 = new Solution1249 ();
        var s1249 = "())()(((";
        var answer1249 = solution1249.MinRemoveToMakeValid(s1249);
        Console.WriteLine(answer1249);

        var solution7 = new Solution7 ();
        var x7 = -12340;
        var answer7 = solution7.Reverse(x7);
        Console.WriteLine(answer7);

        var solution121 = new Solution121();
        var arr121 = new int[] {7,1,5,3,6,4};
        var answer121 = solution121.MaxProfit(arr121);
        Console.WriteLine(answer121);

        var solution74 = new Solution74();
        var arr74 = new int[][] {
                new int[1]{1}};
        var target74 = 1;
        var answer74 = solution74.SearchMatrix(arr74, target74);
        Console.WriteLine(answer74);

        var solution215 = new Solution215();
        var nums215 = new int[] {-1,2,0};
        var k215 = 3;
        var answer215 = solution215.FindKthLargest(nums215, k215);
        Console.WriteLine(answer215);

        var solution746 = new Solution746();
        var arr746 = new int[] {1,100,1,1,1,100,1,1,100,1};
        var answer746 = solution746.MinCostClimbingStairs(arr746);
        Console.WriteLine(answer746);

        var solution26 = new Solution26();
        var arr26 = new int[] {0,0,1,1,1,2,2,3,3,4};
        var answer26 = solution26.RemoveDuplicates(arr26);
        Console.WriteLine(answer26);

        var solution27 = new Solution27();
        var arr27 = new int[] {3,2,2,3};
        var val27 = 3;
        var answer27 = solution27.RemoveElement(arr27, val27);
        Console.WriteLine(answer27);

        var solution35 = new Solution35();
        var arr35 = new int[] {1,3,5,6};
        var target35 = 5;
        var answer35 = solution35.SearchInsert(arr35, target35);
        Console.WriteLine(answer35);

        var solution9 = new Solution9();
        var x9 = -121;
        var answer9 = solution9.IsPalindrome(x9);
        Console.WriteLine(answer9);

        var solution13 = new Solution13();
        var x13 = "LVIII";
        var answer13 = solution13.RomanToInt(x13);
        Console.WriteLine(answer13);

        var solution14 = new Solution14();
        var str14 = new string[] {"flower","flow","flight"};
        var answer14 = solution14.LongestCommonPrefix(str14);
        Console.WriteLine(answer14);

        var solution20 = new Solution20();
        var str20 = "[()]{}";
        var answer20 = solution20.IsValid(str20);
        Console.WriteLine(answer20);

        var solution28 = new Solution28();
        var str28 = "sadbutsad";
        var str128 = "sad";
        var answer28 = solution28.StrStr(str28, str128);
        Console.WriteLine(answer28);

        var solution929 = new Solution929();
        var email929 = new string[] {"test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"};
        var answer929 = solution929.NumUniqueEmails(email929);
        Console.WriteLine(answer929);

        var solution2824 = new Solution2824();
        var arr2824 = new int[] {-1,1,2,3,1};
        var target2824 = 2;
        var answer2824 = solution2824.CountPairs(arr2824, target2824);
        Console.WriteLine(answer2824);

        var solution2828 = new Solution2828();
        var arr2828 = new string[] {"alice","bob","charlie"};
        var s2828 = "abc";
        var answer2828 = solution2828.IsAcronym(arr2828, s2828);
        Console.WriteLine(answer2828);

        var solution804 = new Solution804();
        var arr804 = new string[] {"rwjje","aittjje","auyyn","lqtktn","lmjwn"};
        var answer804 = solution804.UniqueMorseRepresentations(arr804);
        Console.WriteLine(answer804);

        var solution2744 = new Solution2744();
        var arr2744 = new string[] {"cd","ac","dc","ca","zz"};
        var answer2744 = solution2744.MaximumNumberOfStringPairs(arr2744);
        Console.WriteLine(answer2744);

        var solution2176 = new Solution2176();
        var arr2176 = new int[] {3,1,2,2,2,1,3};
        var k2176 = 2;
        var answer2176 = solution2176.CountPairs(arr2176, k2176);
        Console.WriteLine(answer2176);

        var solution1266 = new Solution1266();
        var arr1266 = new int[][] {
                new int[2]{1,1},
                new int[2]{3,4},
                new int[2]{-1,0},
                };
        var answer1266 = solution1266.MinTimeToVisitAllPoints(arr1266);
        Console.WriteLine(answer1266);

        var solution2108 = new Solution2108();
        var arr2108 = new string[] {"abc","car","ada","racecar","cool"};
        var answer2108 = solution2108.FirstPalindrome(arr2108);
        Console.WriteLine(answer2108);

        var solution2778 = new Solution2778();
        var arr2778 = new int[] {1,2,3,4};
        var answer2778 = solution2778.SumOfSquares(arr2778);
        Console.WriteLine(answer2778);

        var solution1827 = new Solution1827();
        var arr1827 = new int[] {1,5,2,4,1};
        var answer1827 = solution1827.MinOperations(arr1827);
        Console.WriteLine(answer1827);

        var solution1725 = new Solution1725();
        var arr1725 = new int[][] {
                new int[2]{5,8},
                new int[2]{3,9},
                new int[2]{5,12},
                new int[2]{16,5}
                };
        var answer1725 = solution1725.CountGoodRectangles(arr1725);
        Console.WriteLine(answer1725);

        var solution2553 = new Solution2553();
        var arr2553 = new int[] {1000,897,1000,60,23};
        var answer2553 = solution2553.SeparateDigits(arr2553);
        Console.WriteLine(answer2553);
        
        var solution942 = new Solution942();
        var s942 = "IDID";
        var answer942 = solution942.DiStringMatch(s942);
        Console.WriteLine(answer942);

        var solution561 = new Solution561();
        var nums561 = new int[] {1,4,3,2};
        var answer561 = solution561.ArrayPairSum(nums561);
        Console.WriteLine(answer561);

        var solution2185 = new Solution2185();
        var s2185 = new string[] {"pay","attention","practice","attend"};
        var pref2185 = "at";
        var answer2185 = solution2185.PrefixCount(s2185, pref2185);
        Console.WriteLine(answer2185);

        var solution1979 = new Solution1979();
        var nums1979 = new int[] {1,4,3,2};
        var answer1979 = solution1979.FindGCD(nums1979);
        Console.WriteLine(answer1979);

        var solution1351 = new Solution1351();
        var nums1351 = new int[][] {
                new int[4]{4,3,2,-1},
                new int[4]{3,2,1,-1},
                new int[4]{1,1,-1,-2},
                new int[4]{-1,-1,-2,-3}
                };
        var answer1351 = solution1351.CountNegatives(nums1351);
        Console.WriteLine(answer1351);

        var solution1295 = new Solution1295();
        var nums1295 = new int[] {12,345,2,6,7896};
        var answer1295 = solution1295.FindNumbers(nums1295);
        Console.WriteLine(answer1295);

        var solution1475 = new Solution1475();
        var nums1475 = new int[] {8,4,6,2,3};
        var answer1475 = solution1475.FinalPrices(nums1475);
        Console.WriteLine(answer1475);

        var solution2733 = new Solution2733();
        var nums2733 = new int[] {3,2,1,4};
        var answer2733 = solution2733.FindNonMinOrMax(nums2733);
        Console.WriteLine(answer2733);

        var solution125 = new Solution125();
        var nums125 = "A man, a plan, a canal: Panama";
        var answer125 = solution125.IsPalindrome(nums125);
        Console.WriteLine(answer125);

        var solution1 = new Solution1();
        var nums1 = new int[] {2,7,11,15};
        var target1 = 9;
        var answer1 = solution1.TwoSum(nums1, target1);
        Console.WriteLine(answer1);
    }
}
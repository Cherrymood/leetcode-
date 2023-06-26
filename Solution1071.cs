public class Solution1071 {
    public string GcdOfStrings(string str1, string str2) {
        
        int len1 = str1.Length;
        int len2 = str2.Length;

        int gcd = GCD(len1, len2);
        string answer = "";

        for (int i = 0; i < len1; i++)
        {
            if (str1[i] != str2[i % len2] || str1[i] != str2[i % gcd])
            {
                return "";
            }
            else if(str1[i] == str2[i % gcd])
            {
                if (i < gcd)
                {
                    answer += str1[i];
                }
            }
        }
        return answer;
    }

public int GCD (int num1, int num2)
{
    int Remainder;
    while (num2 != 0)
    {
        Remainder = num1 % num2;
        num1 = num2;
        num2 = Remainder;
    }
    return num1;
}
}

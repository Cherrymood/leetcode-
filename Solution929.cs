public class Solution929 {
    public int NumUniqueEmails(string[] emails) {
        
        for(int i = 0; i < emails.Length; i++) // delete all '.' in name
        {
            for (int k = 0; k < emails[i].Length; k ++)
            {
                if (emails[i][k] == '@')
                {
                    break;
                }

                else if (emails[i][k] == '.')
                {
                    emails[i] = emails[i].Remove(k, 1);
                }
            }
        }

        for(int i = 0; i < emails.Length; i++) // delete all '+ aditional names' in name
        {
            
            bool flag = false;

            for (int k = 0; k < emails[i].Length; k ++)
            {
                
                if (emails[i][k] == '@')
                {
                    break;
                }

                if (flag == true)
                {
                    emails[i] = emails[i].Remove(k, 1);
                    k--;
                }

                else if (emails[i][k] == '+')
                {
                    emails[i] = emails[i].Remove(k, 1);
                    k--;
                    flag = true;
                }

            }
        }

        var set = new HashSet <string> (emails);

        return set.Count();

        
    }
}
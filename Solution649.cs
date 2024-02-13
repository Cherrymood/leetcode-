public class Solution649 {
    public string PredictPartyVictory(string senate) {
        var q = new Queue<char>();

        foreach(var ch in senate)
        {
            q.Enqueue(ch);
        }

        while(q.Count != 1)
        {
            if(!q.Contains('R') || !q.Contains('D')) break;
            var senator = q.Dequeue();
            var counterD = 0;
            var counterR = 0;

            if(senator == 'D')
            {
                q.Enqueue(senator);
                counterD++;
                while(counterD != 0)
                {
                    var senator1 = q.Dequeue();
                    if(senator1 == 'R')
                    {
                        counterD--;
                    }
                    if(senator1 == 'D')
                    {
                        counterD++;
                        q.Enqueue(senator1);
                    }

                    if(!q.Contains('R') || !q.Contains('D')) break;
                    
                }
            }
            if(senator == 'R')
            {
                q.Enqueue(senator);
                counterR++;
                while(counterR != 0)
                {
                    var senator1 = q.Dequeue();
                    if(senator1 == 'D')
                    {
                        counterR--;
                    }
                    if(senator1 == 'R')
                    {
                        counterR++;
                        q.Enqueue(senator1);
                    }

                    if(!q.Contains('R') || !q.Contains('D')) break;
                    
                }
            }
        }

        if(q.Peek() == 'D') return "Dire";
        else return "Radiant";
    }
}

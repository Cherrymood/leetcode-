    public class Solution685 {
        public int CalPoints(string[] operations) {
            
            int ans = 0;
            var st = new Stack<int>();

            for(int i = 0; i < operations.Length; i++)
            {
                if(operations[i] != "D" && operations[i] != "C" && operations[i] != "+")
                {
                    var num = Int32.Parse(operations[i]);
                    st.Push(num);
                }
                if(operations[i] == "D" && st.Count > 0)
                {
                    st.Push(st.Peek()*2);
                }
                if(operations[i] == "+" && st.Count >= 2)
                {
                    var num1 = st.Pop();
                    var num2 = st.Pop();
                    var num3 = num1 + num2;

                    st.Push(num2);
                    st.Push(num1);
                    st.Push(num3);
                }
                if(operations[i] == "C" && st.Count > 0)
                {
                    st.Pop();
                }
                
            }

            while(st.Count != 0)
            {
                var num = st.Pop();
                ans += num;
            }

            return ans;
        }
    }
public class Solution150 {
    public int EvalRPN(string[] tokens) {
        
        var stack = new Stack<int>();

        foreach (var s in tokens)
        {
            if(s != "+" && s != "-" && s != "*" && s != "/")
            {
                stack.Push(int.Parse(s));
                Console.WriteLine(s);
            }
            else
            {
                var num2 = stack.Pop();
                var num1 = stack.Pop();

                if(s == "+") 
                {
                    stack.Push(num1+num2);
                    Console.WriteLine(s);
                }
                else if(s == "-") 
                {
                    stack.Push(num1-num2);
                    Console.WriteLine(s);
                }
                else if(s == "*") 
                {
                    stack.Push(num1*num2);
                    Console.WriteLine(s);
                }
                else 
                {
                    stack.Push(num1/num2);
                    Console.WriteLine(s);
                }
            }
        }
        return stack.Pop();
    }
}

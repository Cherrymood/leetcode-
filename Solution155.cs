public class MinStack155 {

    Stack<(int minValue, int val)> st;
    int minValue;

    public MinStack() {
        st = new Stack<(int, int)>();
        minValue = int.MaxValue;
    }
    
    public void Push(int val) {
        if(val < minValue)
        {
            minValue = val;
        }

        st.Push((minValue, val));
    }
    
    public void Pop() {
        st.Pop();
        if(st.Count > 0)
        {
            minValue = st.Peek().minValue;
        }
        else
        {
            minValue = int.MaxValue;
        }
    }
    
    public int Top() {

        return st.Peek().val;
    }
    
    public int GetMin() {
        return st.Peek().minValue;
    }
}

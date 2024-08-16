public class LRUCache {

    private int _capacity;
    private Dictionary<int, LinkedListNode<CacheItem>> _cache;
    private LinkedList<CacheItem> _order;

    public LRUCache(int capacity) {
        
        _capacity = capacity;
        _order = new LinkedList<CacheItem>();
        _cache = new Dictionary<int, LinkedListNode<CacheItem>>();
    }
    
    public int Get(int key) {

        if(_cache.TryGetValue(key, out var node))
        {
            _order.Remove(node);
            _order.AddFirst(node);
            return node.Value.Value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {

        if(_cache.TryGetValue(key, out var node))
        {
            node.Value.Value = value;
            _order.Remove(node);
            _order.AddFirst(node);
        }
        else
        {
            if(_cache.Count >= _capacity)
            {
                var last = _order.Last;
                _cache.Remove(last.Value.Key);
                _order.Remove(last);
            }

            var newNode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
            _cache[key] = newNode;
            _order.AddFirst(newNode);
        }
    }

    private class CacheItem
    {
        public int Key { get; }
        public int Value { get; set; }

        public CacheItem(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}

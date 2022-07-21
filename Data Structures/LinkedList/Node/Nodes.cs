namespace Node
{
    public class Nodes<T>
    {
        public Nodes(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Nodes<T> Next { get; set; }
        
    }
}
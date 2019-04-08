namespace CW_4
{
    public class Node<T>
    {
        public Node(T value)
        {
            this.value = value;
        }

        public Node(Node<T> nextNode)
        {
            this.NextNode = nextNode;
        }
        public T value { get; set; }

        public Node<T> NextNode { get;  set; }
    }
}
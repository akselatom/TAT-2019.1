namespace CW_4
{
    /// <summary>
    /// The node. Contains value and reference to next node
    /// </summary>
    /// <typeparam name="T">
    /// value type
    /// </typeparam>
    public class Node<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public Node(T value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="nextNode">
        /// The next node.
        /// </param>
        public Node(Node<T> nextNode)
        {
            this.NextNode = nextNode;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Gets or sets the next node.
        /// </summary>
        public Node<T> NextNode { get;  set; }
    }
}
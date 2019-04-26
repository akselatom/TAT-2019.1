namespace CW_4
{
    using System;

    /// <summary>
    /// My list class
    /// </summary>
    /// <typeparam name="T">
    /// type of data
    /// </typeparam>
    public class MyList<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyList{T}"/> class.
        /// </summary>
        /// <param name="headNode">
        /// The head node.
        /// </param>
        public MyList(Node<T> headNode)
        {
            this.Head = headNode;
        }

        /// <summary>
        /// The on added handler.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public delegate void OnAddedHandler(string message);

        /// <summary>
        /// The element added.
        /// </summary>
        public event OnAddedHandler ElementAdded;

        /// <summary>
        /// The added in another list event
        /// </summary>
        public event EventHandler<T> AddedInAnotherList;
        
        /// <summary>
        /// Gets or sets first value of the list
        /// </summary>
        public Node<T> Head { get; set; }

        /// <summary>
        /// Add value in <see cref="MyList{T}"/>
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Throw exception when input data does not match with head value type
        /// </exception>
        public void Add(T value)
        {
            if (this.Head.Value.GetType() == value.GetType())
            {
                var currentNode = this.Head;
                while (currentNode.NextNode != null)
                {
                    currentNode = currentNode.NextNode;
                }

                currentNode.NextNode = new Node<T>(value);
                var onElementAdded = this.ElementAdded;
                if (onElementAdded != null)
                {
                    onElementAdded("Added new element " + value);
                }

                this.AddedInAnotherList.Invoke(this, value);
            }
            else
            {
                throw new ArgumentException("Wrong type data!");
            }
        }

        /// <summary>
        /// Search method that checks whether this value is in the list
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// returns true if list contains this value
        /// </returns>
        public bool Search(T value)
        {
            var currentNode = this.Head;
            do
            {
                if (currentNode.Value.ToString() == value.ToString())
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }
            while (currentNode != null);
            return false;
        }

        /// <summary>
        /// when adding a value, checks the presence of this value in all sheets subscribed to the event <see cref="AddedInAnotherList"/>
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <param name="args">
        /// The args.
        /// </param>
        public void CheckIsExist(object obj, T args)
        {
            if (this.Search(args))
            {
                Console.WriteLine("This value is exists at another list");
            }
        }
    }
}
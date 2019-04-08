namespace CW_4
{
    using System;

    public class MyList<T>
    {

        public Node<T> Head { get; set; }

        public MyList(Node<T> headNode)
        {
            this.Head = headNode;
        }

        public delegate void OnAddedHandler(string message);

        /// <summary>
        /// The element added.
        /// </summary>
        public event OnAddedHandler ElementAdded;

        public event EventHandler<T> AddedInAnotherList;
        public void Add(T value)
        {
            if (this.Head.value.GetType() == value.GetType())
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

        public bool Search(T value)
        {
            var currentNode = this.Head;
            do
            {
                if (currentNode.value.ToString() == value.ToString())
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }
            while (currentNode != null);
            return false;
        }

        public void CheckIsExist(object obj, T args)
        {
            if (this.Search(args))
            {
                Console.WriteLine("This value is exists at another list");
            }
        }

    }
}
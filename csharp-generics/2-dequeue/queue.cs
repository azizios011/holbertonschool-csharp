using System;

namespace CustomQueue
{
    /// <summary>
    /// Represents a generic queue data structure.
    /// </summary>
    /// <typeparam name="T">The type of elements in the queue.</typeparam>
    public class Queue<T>
    {
        /// <summary>
        /// Represents a node in the queue.
        /// </summary>
        public class Node
        {
            /// <summary>
            /// Gets or sets the value of the node.
            /// </summary>
            public T Value { get; set; }

            /// <summary>
            /// Gets or sets the next node in the queue.
            /// </summary>
            public Node Next { get; set; }

            /// <summary>
            /// Initializes a new instance of the Node class with a given value.
            /// </summary>
            /// <param name="value">The value to set for the new node.</param>
            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        /// <summary>
        /// Initializes a new instance of the Queue class.
        /// </summary>
        public Queue()
        {
            head = null;
            tail = null;
            count = 0;
        }

        /// <summary>
        /// Adds a new node to the end of the queue.
        /// </summary>
        /// <param name="value">The value to be added to the queue.</param>
        public void Enqueue(T value)
        {
            Node newNode = new Node(value);

            if (tail != null)
            {
                tail.Next = newNode;
            }
            tail = newNode;

            if (head == null)
            {
                head = tail;
            }

            count++;
        }

        /// <summary>
        /// Removes the first node from the queue and returns its value.
        /// </summary>
        /// <returns>The value of the removed node, or default value if the queue is empty.</returns>
        public T Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }

            T value = head.Value;
            head = head.Next;

            if (head == null)
            {
                tail = null;
            }

            count--;
            return value;
        }

        /// <summary>
        /// Returns the number of nodes in the queue.
        /// </summary>
        /// <returns>The number of nodes in the queue.</returns>
        public int Count()
        {
            return count;
        }
    }
}

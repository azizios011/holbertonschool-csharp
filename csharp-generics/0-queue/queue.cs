using System;


    /// <summary>
    /// Represents a generic queue data structure.
    /// </summary>
    /// <typeparam name="T">The type of elements in the queue.</typeparam>
    public class Queue<T>
    {
        /// <summary>
        /// Gets the type of the elements in the queue.
        /// </summary>
        /// <returns>The fully qualified name of the type parameter <typeparamref name="T"/>.</returns>
        public string CheckType()
        {
            // Returns the type of the generic parameter T
            return typeof(T).FullName;
        }
    }

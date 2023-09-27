namespace Dewey_Decimal_System_Library.LinkedLists
{
    /// <summary>
    /// Represents a node in a linked list.
    /// </summary>
    /// <typeparam name="T">The type of data stored in the node.</typeparam>
    public class Node<T>
    {
        #region Properties

        /// <summary>
        /// Gets or sets the reference to the next node in the linked list.
        /// </summary>
        public Node<T> Next { get; set; }

        /// <summary>
        /// Gets or sets the reference to the previous node in the linked list.
        /// </summary>
        public Node<T> Previous { get; set; }

        /// <summary>
        /// Gets or sets the data stored in the node.
        /// </summary>
        public T Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        public Node() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class with specified data.
        /// </summary>
        /// <param name="n">The data to be stored in the node.</param>
        public Node(T n)
        {
            Next = null;
            Previous = null;
            Data = n;
        }

        #endregion

    }//End of Class
}//End of Namespace
//---------------------------------------------------------------------------------------oooo0000End of File0000oooo----------------------------------------------------------------------------------------------------------------------

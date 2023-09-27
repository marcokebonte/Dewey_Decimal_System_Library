namespace Dewey_Decimal_System_Library.Model
{


    /// <summary>
    /// Represents a book model with a call number.
    /// </summary>
    public class BookModel : IComparable<BookModel>
    {
        #region Properties

        /// <summary>
        /// Gets or sets the call number of the book.
        /// </summary>
        public string CallNumber { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BookModel"/> class with a call number.
        /// </summary>
        /// <param name="callNumber">The call number of the book.</param>
        public BookModel(string callNumber)
        {
            CallNumber = callNumber;
        }

        #endregion

        #region IComparable Implementation

        /// <summary>
        /// Compares this book model to another book model based on their call numbers.
        /// </summary>
        /// <param name="other">The other book model to compare to.</param>
        /// <returns>
        /// A negative integer if this book's call number is less than the other book's call number,
        /// 0 if they are equal, or a positive integer if this book's call number is greater.
        /// </returns>
        public int CompareTo(BookModel other)
        {
            return this.CallNumber.CompareTo(other.CallNumber);
        }

        #endregion


    }//End of Class
}//End of Namespace
//------------------------------------------------------------------------oooo0000End Of File0000oooo--------------------------------------------------------------------

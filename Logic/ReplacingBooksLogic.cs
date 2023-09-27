using Dewey_Decimal_System_Library.LinkedLists;
using Dewey_Decimal_System_Library.Model;

namespace Dewey_Decimal_System_Library.Logic
{
    public class ReplacingBooksLogic
    {



        #region Generate Call Numbers
        public List<string> GenerateCallNos()
        {
            // declare varibales
            string period = "";

            // instantiate random obj
            Random rnd = new Random();

            // declare and initalise list and linked list
            CLinkedList<BookModel> books = new CLinkedList<BookModel>();
            List<string> callnums = new List<string>();

            // loop
            for (int i = 0; i < 10; i++)
            {
                //generate a random number 1 >= n <= 999
                int number = rnd.Next(1, 1000);

                // generate a random number between 1 and 10
                int reCheck = rnd.Next(1, 11);

                // uniqueness check 
                if (reCheck > 4) { period = $".{rnd.Next(1, 100)}"; }
                string author = RandomString(3);
                BookModel b = new BookModel($"{number.ToString().PadLeft(3, '0')}{period} {author}");

                books.Append(b);
            }

            // adds the current obj to the head of the single linked list
            books.QuickSort(books.Head);

            // iterate through linked list
            foreach (BookModel book in books)
            {
                // add to 
                callnums.Add(book.CallNumber);
            }

            return callnums;
        }

        #endregion

        #region Generate Random String
        public string RandomString(int size)
        {
            // instantiate random obj
            Random rnd = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            return new string(Enumerable.Repeat(chars, size).Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
        #endregion

        #region Shuffle List

        public List<string> ShuffleList(List<string> myList)
        {
            // instantiate random obj
            Random rnd = new Random();

            return myList.OrderBy(item => rnd.Next()).ToList();
        }
        #endregion

    }//End of Class
}//End of Namespace 
 //--------------------------------------------------------------------oooo0000End of File0000oooo----------------------------------------------------------------------
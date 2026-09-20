namespace session07Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Book book = new Book();
            // Console.WriteLine(book.password);
            //password is only accessible within its own class
            #endregion

            #region Q2

            Console.WriteLine(book.copiesInStock);
            // internal is accessible within its project

            #endregion

            #region Q3

            Console.WriteLine(book.Title);

            #endregion

            #region Q4

            book.Genre = Genre.Science;
            Console.WriteLine(book.Genre);

            #endregion

            #region Q5

            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);

            #endregion


            Console.ReadLine();
        }
    }
}
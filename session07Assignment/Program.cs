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

            #region Q6

            int genreNumber = 1;
            Genre genre = (Genre)genreNumber;
            Console.WriteLine(genre);

            #endregion

            #region Q7

            Genre genre1 = Genre.Fiction;
            Console.WriteLine(genre1.ToString());

            #endregion

            #region Q8

            string genreText = "Science";
            Genre genre2 = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine(genre2);

            #endregion

            #region Q9

            string genreText1 = "Mystery";
            if(Enum.TryParse(genreText1, out Genre genre3)){
                Console.WriteLine(genre);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
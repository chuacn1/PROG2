namespace ListManipulation_BookTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bookTitles = new List<string>() { "The Great Gatsby", "To Kill a Mockingbird", "1984", "Brave New World" };


            //============= GET TOTAL NUMBER OF BOOKS ============//
            int totalBooks = 0;

            for (int i = 0; i < bookTitles.Count; i++)
            {
                totalBooks++;
            }

            Console.WriteLine(totalBooks);
            Console.ReadLine();


            //============= CONTAINS ============//
            bool hasBraveNewWorld = bookTitles.Contains("Brave New World");
            Console.WriteLine(hasBraveNewWorld);
            Console.ReadLine();

            int index1984 = bookTitles.FindIndex(title => title == "1984");
            Console.WriteLine(index1984);
            Console.ReadLine();

            //============= CLEAR ============//
            // When you clear the list using bookTitles.Clear(), it removes all elements.
            // Printing the list itself will just output System.Collections.Generic.List
            // because bookTitles is a List<string>, which doesn't override ToString() to display the contents.

            bookTitles.Clear();
            Console.WriteLine("Books cleared. The list is now empty.");
            Console.ReadLine();

            Console.ReadLine();



        }
    }
}
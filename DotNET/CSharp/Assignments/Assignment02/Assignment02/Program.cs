using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------Q1-------------------");
        // Question 1
        string title = "clean code";
        string upperTitle = title.ToUpper();

        Console.WriteLine(title);
        Console.WriteLine(upperTitle);
        Console.WriteLine();

        Console.WriteLine("------------Q2-------------------");
        // Question 2
        string book1 = "Clean Code";
        string book2 = "Clean Code";

        Console.WriteLine(ReferenceEquals(book1, book2));
        Console.WriteLine();

        Console.WriteLine("------------Q3-------------------");
        // Question 3
        StringBuilder builder = new StringBuilder();
        builder.Append("Book List");
        builder.Append(" - Updated");

        Console.WriteLine(builder);
        Console.WriteLine();

        Console.WriteLine("------------Q4-------------------");
        // Question 4
        builder.Replace("Book List", "Library");

        Console.WriteLine(builder);
        Console.WriteLine();

        Console.WriteLine("------------Q5-------------------");
        // Question 5
        title = "Clean Code";
        int pages = 464;

        string sentenceq5 = "Book: " + title + ", Pages: " + pages;
        Console.WriteLine(sentenceq5);
        Console.WriteLine();

        Console.WriteLine("------------Q6-------------------");
        // Question 6
        string sentenceq6 = $"Book: {title}, Pages: {pages}";
        Console.WriteLine(sentenceq6);
        Console.WriteLine();

        Console.WriteLine("------------Q7-------------------");
        // Question 7
        string sentenceq7 = string.Format("Book: {0}, Pages: {1}", title, pages);
        Console.WriteLine(sentenceq7);
        Console.WriteLine();

        Console.WriteLine("------------Q8-------------------");
        // Question 8
        if (pages > 300)
        {
            Console.WriteLine("Long Book");
        }
        else
        {
            Console.WriteLine("Short Book");
        }
        Console.WriteLine();

        Console.WriteLine("------------Q9-------------------");
        // Question 9
        bool isAvailable = true;

        if (pages > 300 && isAvailable)
        {
            Console.WriteLine("You can borrow this book");
        }
        Console.WriteLine();

        Console.WriteLine("------------Q10-------------------");
        // Question 10
        title = "Refactoring";

        switch (title)
        {
            case "Clean Code":
                Console.WriteLine("Great choice!");
                break;

            case "Refactoring":
                Console.WriteLine("Nice pick!");
                break;

            default:
                Console.WriteLine("Never heard of it");
                break;
        }
        Console.WriteLine();

        Console.WriteLine("------------Q11-------------------");
        // Question 11
        string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

        Console.WriteLine(sizeLabel);
        Console.WriteLine();

        Console.WriteLine("------------Q12-------------------");
        // Question 12
        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{i + 1}" + "{books[i]}");
        }
        Console.WriteLine();

        Console.WriteLine("------------Q13-------------------");
        // Question 13
        int index = 0;

        while (index < books.Length)
        {
            Console.WriteLine(books[index]);
            index++;
        }
        Console.WriteLine();

        Console.WriteLine("------------Q14-------------------");
        // Question 14
        int count = 0;

        do
        {
            Console.WriteLine("Checking book...");
            count++;
        }
        while (count < 3);
        Console.WriteLine();

        Console.WriteLine("------------Q15-------------------");
        // Question 15
        foreach (string book in books) //3 books in the array, so this will run 3 times
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();


        Console.WriteLine("------------Q16-------------------");
        // Question 16
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == "Refactoring")
            {
                break;
            }

            Console.WriteLine(books[i]);
        }
        Console.WriteLine();


        Console.WriteLine("------------Q17-------------------");
        // Question 17
        foreach (string book in books)
        {
            if (book == "The Pragmatic Programmer")
            {
                continue;
            }

            Console.WriteLine(book);
        }
        Console.WriteLine();

        Console.WriteLine("------------Q18-------------------");
        // Question 18
        PrintFirstBook(books);
    }
    // out of the main level also I can do it in a separete file and call it here normally

    static void PrintFirstBook(string[] books)
    {
        if (books.Length == 0)
        {
            Console.WriteLine("It's an empty array");
            return;
        }

        Console.WriteLine(books[0]);
    }

}

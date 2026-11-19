using System;

// Q01
Console.WriteLine("\n--- Q01 ---");
object book = new Book
{
    Title = "C# Basics",
    Pages = 464
};
Console.WriteLine(book);

// Q02
Console.WriteLine("\n--- Q02 ---");
Book book02 = new()
{
    Title = "C# Basics",
    Pages = 464
};
Console.WriteLine(book02.ToString());
Console.WriteLine(book02.Equals(book02));
Console.WriteLine(book02.GetHashCode());
Console.WriteLine(book02.GetType());

// Q03 we need to parse a string to an integer
Console.WriteLine("\n--- Q03 ---");
int pages = int.Parse("464");
Console.WriteLine(pages);

// Q04
Console.WriteLine("\n--- Q04 ---");
try
{
    int x = 10;
    int y = 0;
    Console.WriteLine(x / y);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}

// Q05
Console.WriteLine("\n--- Q05 ---");
int pagesq5 = 300;
double totalPages = pagesq5;
Console.WriteLine(totalPages);

// Q06
Console.WriteLine("\n--- Q06 ---");
double price = 49.99; //49 
int wholePrice = (int)price;
Console.WriteLine(wholePrice);

// Q07
Console.WriteLine("\n--- Q07 ---");
string pagesText = "464";
int pagesq7 = Convert.ToInt32(pagesText);
Console.WriteLine(pagesq7);

// Q08
Console.WriteLine("\n--- Q08 ---");
string yearText = "2023";
int year = int.Parse(yearText);
Console.WriteLine(year);
string badText = "abc";
if (int.TryParse(badText, out int number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Invalid number");
}

// Q09
Console.WriteLine("\n--- Q09 ---");
int pagesq9 = 464;
string pagesTextq9 = pagesq9.ToString();
Console.WriteLine(pagesTextq9);
Console.WriteLine(pagesTextq9.GetType());

// Q10
Console.WriteLine("\n--- Q10 ---");
int copies = 100;
object boxedCopies = copies;
int unboxedCopies = (int)boxedCopies;
Console.WriteLine(boxedCopies);
Console.WriteLine(unboxedCopies);

// Q11
Console.WriteLine("\n--- Q11 ---");
int? yearr = null;
Console.WriteLine(yearr.HasValue);
yearr = 2023;
Console.WriteLine(yearr.Value);

// Q12
Console.WriteLine("\n--- Q12 ---");
string? reviewer = null;
Console.WriteLine(reviewer == null);

// Q13
Console.WriteLine("\n--- Q13 ---");
Book? bookq13 = null;
string? titleq13 = bookq13?.Title;
Console.WriteLine(titleq13);

// Q14
Console.WriteLine("\n--- Q14 ---");
Book? bookq14 = null;
string? titleq14 = bookq14?.Title;
Console.WriteLine(titleq14 ?? "Untitled");
titleq14 ??= "Untitled";
Console.WriteLine(titleq14);

// Q15
Console.WriteLine("\n--- Q15 ---");
string? nameq15 = "Ahmed";
string confirmedName = nameq15!;
Console.WriteLine(confirmedName);

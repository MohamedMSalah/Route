using System;

Q01(); Q02(); Q03(); Q04(); Q05(); Q06(); Q07(); Q08(); Q09(); Q10(); Q11(); Q12(); Q13(); Q14(); Q15();

static void Heading(int n) => Console.WriteLine($"\n--- Q{n:00} ---");
static void Q01() { Heading(1); object book = new Book { Title = "C# Basics", Pages = 464 }; Console.WriteLine(book); }
static void Q02() { Heading(2); Book book = new() { Title = "C# Basics", Pages = 464 }; Console.WriteLine(book.ToString()); Console.WriteLine(book.Equals(book)); Console.WriteLine(book.GetHashCode()); Console.WriteLine(book.GetType()); }
static void Q03() { Heading(3); /* int pages = "464"; is a compile-time error */ int pages = int.Parse("464"); Console.WriteLine(pages); }
static void Q04() { Heading(4); try { int x = 10, y = 0; Console.WriteLine(x / y); } catch (DivideByZeroException) { Console.WriteLine("Cannot divide by zero"); } finally { Console.WriteLine("Done"); } }
static void Q05() { Heading(5); int pages = 300; double totalPages = pages; Console.WriteLine(totalPages); }
static void Q06() { Heading(6); double price = 49.99; int wholePrice = (int)price; Console.WriteLine(wholePrice); }
static void Q07() { Heading(7); string pagesText = "464"; int pages = Convert.ToInt32(pagesText); Console.WriteLine(pages); }
static void Q08() { Heading(8); string yearText = "2023"; int year = int.Parse(yearText); Console.WriteLine(year); string badText = "abc"; if (int.TryParse(badText, out int number)) Console.WriteLine(number); else Console.WriteLine("Invalid number"); }
static void Q09() { Heading(9); int pages = 464; string pagesText = pages.ToString(); Console.WriteLine(pagesText); Console.WriteLine(pagesText.GetType()); }
static void Q10() { Heading(10); int copies = 100; object boxedCopies = copies; int unboxedCopies = (int)boxedCopies; Console.WriteLine(boxedCopies); Console.WriteLine(unboxedCopies); }
static void Q11() { Heading(11); int? year = null; Console.WriteLine(year.HasValue); year = 2023; Console.WriteLine(year.Value); }
static void Q12() { Heading(12); string? reviewer = null; Console.WriteLine(reviewer == null); }
static void Q13() { Heading(13); Book? book = null; string? title = book?.Title; Console.WriteLine(title); }
static void Q14() { Heading(14); Book? book = null; string? title = book?.Title; Console.WriteLine(title ?? "Untitled"); title ??= "Untitled"; Console.WriteLine(title); }
static void Q15() { Heading(15); string? name = "Ahmed"; string confirmedName = name!; Console.WriteLine(confirmedName); }

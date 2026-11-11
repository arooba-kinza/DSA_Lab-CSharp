
using System;

namespace MyProgram
{
    public class Book
    {
        // Fields
        public string Title;     // Non-primitive (reference type)
        public int Pages;        // Primitive (value type)
        public double Price;     // Primitive (value type)
        public bool Available;   // Primitive (value type)

        // Constructor
        public Book(string t, int p, double pr, bool av)
        {
            this.Title = t;
            this.Pages = p;
            this.Price = pr;
            this.Available = av;
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Array of three Book objects
            Book[] books =
            {
                new Book("mala", 1000, 5000, true),
                new Book("atomic habit", 200, 500, true),
                new Book("nigel kelly", 600, 1500, false)
            };

            // Print each book on one line
            foreach (Book b in books)
            {
                Console.WriteLine(
                    $"Title: {b.Title}, Pages: {b.Pages}, Price: {b.Price}, Available: {b.Available}"
                );
            }

            // Calculate total price
            double totalPrice = 0;

            foreach (Book b in books)
            {
                totalPrice += b.Price;
            }

            Console.WriteLine($"Total Price: {totalPrice}");
        }
    }
}

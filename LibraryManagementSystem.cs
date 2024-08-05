using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    // Interface segregation principle: Separate interfaces for different functionalities
    public interface IBookRepository
    {
        void AddBook(Book book);
        Book GetBook(string isbn);
    }

    public interface IBookLoanService
    {
        void LoanBook(string isbn, string memberId);
        void ReturnBook(string isbn);
    }

    // Single responsibility principle: Each class has a single responsibility
    public class Book
    {
        public string ISBN { get; }
        public string Title { get; }
        public string Author { get; }

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }
    }

    // Open/closed principle: This class is open for extension but closed for modification
    public abstract class LibraryMember
    {
        public string MemberId { get; }
        public string Name { get; }

        protected LibraryMember(string memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }

        public abstract int MaxLoanPeriod { get; }
    }

    // Liskov substitution principle: Derived classes can be substituted for their base class
    public class RegularMember : LibraryMember
    {
        public RegularMember(string memberId, string name) : base(memberId, name) { }
        public override int MaxLoanPeriod => 14;
    }

    public class PremiumMember : LibraryMember
    {
        public PremiumMember(string memberId, string name) : base(memberId, name) { }
        public override int MaxLoanPeriod => 28;
    }

    // Dependency inversion principle: High-level modules depend on abstractions
    public class Library : IBookRepository, IBookLoanService
    {
        private readonly Dictionary<string, Book> _books = new Dictionary<string, Book>();
        private readonly Dictionary<string, string> _loanedBooks = new Dictionary<string, string>();

        public void AddBook(Book book)
        {
            _books[book.ISBN] = book;
        }

        public Book GetBook(string isbn)
        {
            return _books.TryGetValue(isbn, out var book) ? book : null;
        }

        public void LoanBook(string isbn, string memberId)
        {
            if (!_books.ContainsKey(isbn))
                throw new ArgumentException("Book not found", nameof(isbn));

            if (_loanedBooks.ContainsKey(isbn))
                throw new InvalidOperationException("Book is already loaned");

            _loanedBooks[isbn] = memberId;
        }

        public void ReturnBook(string isbn)
        {
            if (!_loanedBooks.ContainsKey(isbn))
                throw new ArgumentException("Book is not currently loaned", nameof(isbn));

            _loanedBooks.Remove(isbn);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var library = new Library();

            // Add some books
            library.AddBook(new Book("123456", "Clean Code", "Robert C. Martin"));
            library.AddBook(new Book("789012", "Design Patterns", "Erich Gamma"));

            // Create some members
            var regularMember = new RegularMember("R001", "John Doe");
            var premiumMember = new PremiumMember("P001", "Jane Smith");

            // Loan and return books
            try
            {
                library.LoanBook("123456", regularMember.MemberId);
                Console.WriteLine($"Book loaned to {regularMember.Name} for {regularMember.MaxLoanPeriod} days");

                library.ReturnBook("123456");
                Console.WriteLine("Book returned");

                library.LoanBook("789012", premiumMember.MemberId);
                Console.WriteLine($"Book loaned to {premiumMember.Name} for {premiumMember.MaxLoanPeriod} days");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
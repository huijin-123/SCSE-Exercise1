using System;

class Program
{
    static void Main(string[] args)
    {
        LibraryManager library = new LibraryManager();
        
        library.AddItem(new Novel(1, "The Great Gatsby", "F. Scott Fitzgerald"));
        library.AddItem(new Magazine(2, "National Geographic", 202509));
        library.AddItem(new TextBook(3, "C# Basics", "Tech Publishers"));
        library.AddItem(new Novel(4, "1984", "George Orwell"));

        Console.WriteLine("=== Registering Members ===");
        Member alice = new Member("Alice");
        library.RegisterMember(alice);
        
        Member bob = new Member("Bob");
        library.RegisterMember(bob);
        Console.WriteLine();

        Console.WriteLine("=== Library Catalog ===");
        library.ShowCatalog();
        Console.WriteLine();

        Console.WriteLine("=== Alice's Borrowing History ===");
        LibraryItem? item1 = library.FindItemById(1);
        if (item1 != null)
        {
            Console.WriteLine(alice.BorrowItem(item1));
        }

        LibraryItem? item2 = library.FindItemById(2);
        if (item2 != null)
        {
            Console.WriteLine(alice.BorrowItem(item2));
        }

        LibraryItem? item3 = library.FindItemById(3);
        if (item3 != null)
        {
            Console.WriteLine(alice.BorrowItem(item3));
        }

        LibraryItem? newNovel = library.FindItemById(4);
        if (newNovel != null)
        {
            Console.WriteLine(alice.BorrowItem(newNovel));
        }
    }
}
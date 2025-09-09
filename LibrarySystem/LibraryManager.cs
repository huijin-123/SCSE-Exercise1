using System.Collections.Generic;
using System;

public class LibraryManager
{
    private readonly List<LibraryItem> _catalog;
    private readonly List<Member> _members;

    public LibraryManager()
    {
        _catalog = new List<LibraryItem>();
        _members = new List<Member>();
    }

    public void AddItem(LibraryItem item)
    {
        _catalog.Add(item);
    }

    public void RegisterMember(Member member)
    {
        _members.Add(member);
        Console.WriteLine($"Member '{member.Name}' has been successfully registered.");
    }

    public void ShowCatalog()
    {
        Console.WriteLine("Library Catalog:");
        foreach (var item in _catalog)
        {
            Console.WriteLine(item.GetDetails());
        }
    }

    public LibraryItem? FindItemById(int id) => _catalog.Find(i => i.Id == id);

    public Member? FindMemberByName(string name) => _members.Find(m => m.Name == name);
}
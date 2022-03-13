using Homework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books { get; }
        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(string value);
        
    }
}
using Homework.Interfaces;
using Homework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Services
{
    class LibraryManager : ILibraryManager
    {
        private List<Book> _books;
        public List<Book> Books => _books;

        public LibraryManager()
        {
            _books = new List<Book>();
        }
       
        public List<Book> Search(string value)
        {
            return _books.FindAll(books => books.Author.Contains(value) ||
            books.Genre.ToString().Contains(value) ||
            books.PageCount.ToString().Contains(value) || books.Name.Contains(value));
        }
        
        

        public void Add(Book book)
        {
            if (_books.Count > 0 && _books.Exists(b => b.Name == book.Name))
            {
                throw new SameBookalreadyAddedExpection($"{book.Name} elave oluna bilmedi");
            }

            _books.Add(book);

        }

        public Book ShowInfo(string name)
        {
            throw new NotImplementedException();
        }
    }
}
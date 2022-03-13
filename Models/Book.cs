using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Genre Genre { get; set; }
        public Book(string name, string author, int pagecount, Genre genre)
        {
            Name = name;
            Author = author;
            PageCount = pagecount;
            
        }
        public override string ToString()
        {
            return $"Ad: {Name}\n Yazici: {Author}\n Sehife Sayi: {PageCount}";
        }
    }
}
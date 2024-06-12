using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Book
    {
        private static int bookCount = 0;

        private string title;
        private string author;
        private int pages;

        public Book() { }

        public Book(string title, string author, int pages)
        {
            Book.bookCount++;
            this.title = title;
            this.author = author;
            this.Pages = pages;
        }

        ~Book()
        {
            Book.bookCount--;
        }

        public static int getBookCount()
        {
            return Book.bookCount;
        }

        public int Pages
        {
            get { return this.pages; }
            set {
                if (value > 0) this.pages = value;
            }
        }

        override
        public String ToString()
        {
            return this.title + ' ' + this.author + ' ' + this.pages;
        }
    }
}

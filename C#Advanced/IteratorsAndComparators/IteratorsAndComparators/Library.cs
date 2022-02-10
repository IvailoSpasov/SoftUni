using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int index;
            public LibraryIterator(List<Book> books)
            {
                this.books = books;
                index = -1;
            }

            public bool MoveNext()
            {
                index++;
                return index < books.Count;
            }

            public void Reset()
            {
            }

            public Book Current => books[index];

            object? IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

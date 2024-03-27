using CSProjeDemo1.Abstract;
using CSProjeDemo1.Concrete.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete.Classes
{
    public class Member : IMember
    {
        public Member(string name, string surname)
        {
            Name = name;
            Surname = surname;
            BorrowedBooks = new List<Book>();

        }
        /// <summary>
        /// Ensures each member has a unique identification number
        /// </summary>
        public string MemberNumber => Guid.NewGuid().ToString(); 

        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Book> BorrowedBooks { get; }


        /// <summary>
        /// Adds the book to the borrowed books list
        /// Changes the book's situation enum to borrowed
        /// </summary>
        /// <param name="book">Barrowed Book</param>
        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
            book.Situation = Situation.Borrowed;
        }

        /// <summary>
        /// Removes the book to the borrowed books list
        /// Changes the book's situation enum to available
        /// </summary>
        /// <param name="book">Returned Book</param>
        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
            book.Situation = Situation.Available;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSProjeDemo1.Concrete.Classes;

namespace CSProjeDemo1.Abstract
{
    public interface IMember
    {
        public string MemberNumber { get; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Book> BorrowedBooks { get; }

        public void BorrowBook(Book book);
        public void ReturnBook(Book book);

    }
}

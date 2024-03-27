using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete.Classes
{
    public class Library
    {
        public List<Book> BookList { get; set; }

        public void LendBook(Book book) { }

        public void ReturnBook(Book book) { }

        public void UpdateSituation(Book book) { }

    }
}

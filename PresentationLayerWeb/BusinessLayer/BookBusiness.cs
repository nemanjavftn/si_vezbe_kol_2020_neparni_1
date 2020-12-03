using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BookBusiness
    {
        private BookRepository bookRepository = new BookRepository();

        public List<Book> getAllStudents()
        {
            return this.bookRepository.getAllStudents();
        }
        public bool Insert(Book b)
        {
            if (this.bookRepository.InsertBook())
                return true;
            return false;
        }

    }
}

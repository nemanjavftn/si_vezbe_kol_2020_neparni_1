using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class BookBusiness
    {
        private readonly DataRepository dataRepository;

        public BookBusiness()
        {
            this.dataRepository = new DataRepository();
        }

        public List<Book> GetAllBooks()
        {
            return this.dataRepository.GetAllBooks();
        }

        public bool InsertBook(Book b)
        {
            if (this.dataRepository.InsertBook(b) > 0)
            {
                return true;
            }
            return false;
        }
    }
}

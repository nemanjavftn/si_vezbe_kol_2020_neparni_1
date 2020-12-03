using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using DataLayer;

namespace WebApplication1
{
    public partial class books : System.Web.UI.Page
    {
        private BookBusiness bookBusiness;
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        private void refreshList()
        {
            List<Book> books = bookBusiness.GetAllBooks();
            ListBoxBooks.Items.Clear();

            foreach (Book book in books)
                ListBoxBooks.Items.Add($"{book.Id}. {book.Name} {book.Author} ({book.Year})");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        { 
            Book book = new Book {
                Name = tbName.Text,
                Author = tbAuthor.Text,
                Year = Convert.ToInt32(tbYear.Text)
            };

            if(bookBusiness.insertBook(book)) {
                List<Book> books = bookBusiness.GetAllBooks();
                ListBoxBooks.Items.Clear();

                foreach (Book b in books)
                    ListBoxBooks.Items.Add($"{b.Id}. {b.Name} {b.Author} ({b.Year})");
            }
            

        }
    }
}
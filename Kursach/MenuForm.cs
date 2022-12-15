using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            Show();
            registration.Close();
        }

        private void burn_book_Button_Click(object sender, EventArgs e)
        {
            Hide();
            Finder finder = new Finder();
            finder.ShowDialog();
            Show();
            finder.Close();
        }

        private void return_book_Button_Click(object sender, EventArgs e)
        {
            Hide();
            ReturnBookForm returnBook = new ReturnBookForm();
            returnBook.ShowDialog();
            Show();
            returnBook.Close();
        }

        private void delete_book_Button_Click(object sender, EventArgs e)
        {
            Hide();
            DeleteForm delete = new DeleteForm();
            delete.ShowDialog();
            Show();
            delete.Close();
        }

        private void add_book_Button_Click(object sender, EventArgs e)
        {
            Hide();
            AddBookForm addBook = new AddBookForm();
            addBook.ShowDialog();
            Show();
            addBook.Close();
        }

        private void view_statistics_Button_Click(object sender, EventArgs e)
        {
            Hide();
            SraristicForm statistic = new SraristicForm();
            statistic.ShowDialog();
            Show();
            statistic.Close();
        }
    }
}

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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void addbookButton_Click(object sender, EventArgs e)
        {
            if (name_book_textBox.Text == "Введите название книги" || athor_book_textBox.Text == "Введите автора книги" || year_publication_textBox.Text == "Введите год издания" || number_of_booksTextBox.Text == "Введите количество экземпляров книги")
            {
                MessageBox.Show("Вы не заполнили все поля!");
                return;
            }
            string Name = name_book_textBox.Text;
            string author = athor_book_textBox.Text; 
            DateTime date_of_publishing = DateTime.Parse(year_publication_textBox.Text);
            int number_of_copies = Convert.ToInt32(number_of_booksTextBox.Text);
            int kol_vo_vzyat = 0;
            int key1 = Convert.ToInt32(key.Text); 
            Books book = new Books(key1, Name, author, date_of_publishing, number_of_copies);
            Library.Add_Book(key1, Name, author, date_of_publishing, number_of_copies);
            //if (!list.Contains(book)) list.Add(book);
            //Serialization.Serialisation(dict, list);
            this.DialogResult = DialogResult.OK;
        }

        private void return_menuButton_Click(object sender, EventArgs e)
        {
            Hide();
            MenuForm menu = new MenuForm();
            menu.ShowDialog();
            Show();
            menu.Close();
        }

        private void name_book_textBox_Enter(object sender, EventArgs e)
        {
            if (name_book_textBox.Text == "Введите название книги")
            {
                name_book_textBox.Text = String.Empty;
            }
        }

        private void name_book_textBox_Leave(object sender, EventArgs e)
        {
            if (name_book_textBox.Text == String.Empty)
            {
                name_book_textBox.Text = "Введите название книги";
            }
        }

        private void athor_book_textBox_Enter(object sender, EventArgs e)
        {
            if (athor_book_textBox.Text == "Введите автора книги")
            {
                athor_book_textBox.Text = String.Empty;
            }
        }

        private void athor_book_textBox_Leave(object sender, EventArgs e)
        {
            if (athor_book_textBox.Text == String.Empty)
            {
                athor_book_textBox.Text = "Введите автора книги";
            }
        }

        private void year_publication_textBox_Enter(object sender, EventArgs e)
        {
            if (year_publication_textBox.Text == "Введите год издания")
            {
                year_publication_textBox.Text = String.Empty;
            }
        }

        private void year_publication_textBox_Leave(object sender, EventArgs e)
        {
            if (year_publication_textBox.Text == String.Empty)
            {
                year_publication_textBox.Text = "Введите год издания";
            }
        }

        private void name_book_textBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!Error_Debugger.CheckString_Addname(name_book_textBox.Text, out errorMsg))
            {
                e.Cancel = true;
                name_book_textBox.Select(0, name_book_textBox.Text.Length);
                this.errorProvider1.SetError(name_book_textBox, errorMsg);
            }
        }

        private void name_book_textBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(name_book_textBox, "");
        }

        private void athor_book_textBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!Error_Debugger.CheckStringAthor_finder(athor_book_textBox.Text, out errorMsg))
            {
                e.Cancel = true;
                athor_book_textBox.Select(0, athor_book_textBox.Text.Length);
                this.errorProvider1.SetError(athor_book_textBox, errorMsg);
            }
        }

        private void athor_book_textBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(athor_book_textBox, "");
        }

        private void year_publication_textBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            if (!Error_Debugger.CheckYear_Add(year_publication_textBox.Text, out errorMsg))
            {
                e.Cancel = true;
                year_publication_textBox.Select(0, year_publication_textBox.Text.Length);
                this.errorProvider1.SetError(year_publication_textBox, errorMsg);
            }
        }

        private void year_publication_textBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(year_publication_textBox, "");
        }

        private void number_of_booksTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            if (!Error_Debugger.CheckYear(number_of_booksTextBox.Text, out errorMsg))
            {
                e.Cancel = true;
                number_of_booksTextBox.Select(0, number_of_booksTextBox.Text.Length);
                this.errorProvider1.SetError(number_of_booksTextBox, errorMsg);
            }
        }

        private void number_of_booksTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(number_of_booksTextBox, "");
        }

        private void number_of_booksTextBox_Enter(object sender, EventArgs e)
        {
            if (number_of_booksTextBox.Text == "Введите количество экземпляров книги")
            {
                number_of_booksTextBox.Text = String.Empty;
            }
        }

        private void number_of_booksTextBox_Leave(object sender, EventArgs e)
        {
            if (number_of_booksTextBox.Text == String.Empty)
            {
                number_of_booksTextBox.Text = "Введите количество экземпляров книги";
            }
        }

        private void key_Enter(object sender, EventArgs e)
        {
            if (key.Text == "Введите индекс книги")
            {
                key.Text = String.Empty;
            }
        }

        private void key_Leave(object sender, EventArgs e)
        {
            if (key.Text == String.Empty)
            {
                key.Text = "Введите индекс книги";
            }
        }

        private void key_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            if (!Error_Debugger.CheckYear(key.Text, out errorMsg))
            {
                e.Cancel = true;
                key.Select(0, key.Text.Length);
                this.errorProvider1.SetError(key, errorMsg);
            }
        }

        private void key_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(key, "");
        }
    }
}

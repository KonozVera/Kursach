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

    }
}

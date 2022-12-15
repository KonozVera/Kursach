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
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void returnbookButton_Click(object sender, EventArgs e)
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

        private void login_in_find_Field_Enter(object sender, EventArgs e)
        {
            if (login_in_find_Field.Text == "Введите логин")
            {
                login_in_find_Field.Text = String.Empty;
            }
        }

        private void login_in_find_Field_Leave(object sender, EventArgs e)
        {
            if (login_in_find_Field.Text == String.Empty)
            {
                login_in_find_Field.Text = "Введите логин";
            }
        }

        private void index_textBox_Enter(object sender, EventArgs e)
        {
            if (index_textBox.Text == "Введите индекс книги")
            {
                index_textBox.Text = String.Empty;
            }
        }

        private void index_textBox_Leave(object sender, EventArgs e)
        {
            if (index_textBox.Text == String.Empty)
            {
                index_textBox.Text = "Введите индекс книги";
            }
        }
    }
}

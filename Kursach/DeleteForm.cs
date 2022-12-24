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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void deletebookButton_Click(object sender, EventArgs e)
        {
            int Key = Convert.ToInt32(index_textBox.Text);
            //List<Books> list;
            //Dictionary<int, Clients> dict;
            //var tuple = Serialization.Deserialize();
            //list = tuple.Item2;
            //dict = tuple.Item1;
            //(dict, list) = Serialization.Deserialize();
            Library.Delete_Book(Key);
            //Serialization.Serialisation(dict, list);
            MessageBox.Show("Книгу успешно удалили!");
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

        private void index_textBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            if (!Error_Debugger.CheckYear(index_textBox.Text, out errorMsg))
            {
                e.Cancel = true;
                index_textBox.Select(0, index_textBox.Text.Length);
                this.errorProvider1.SetError(index_textBox, errorMsg);
            }
        }

        private void index_textBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(index_textBox, "");
        }

    }
}

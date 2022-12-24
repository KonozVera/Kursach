using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Findknown_bookForm : Form
    {
        private string filters;
        private int filterType;
        public Findknown_bookForm(string filters, int filterType)
        {
            InitializeComponent();
            this.filters = filters;
            this.filterType = filterType;
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

        private void add_bookButton_Click(object sender, EventArgs e)
        {
            if (login_in_find_Field.Text == "Введите логин")
            {
                MessageBox.Show("Вы не заполнили все поля!");
                return;
            }

            if (all_bookcheckedListBox.CheckedItems.Count != 0)
            {
                string s = "";
                for (int x = 0; x < all_bookcheckedListBox.CheckedItems.Count; x++)
                {
                    s = s + (x + 1).ToString() + all_bookcheckedListBox.CheckedItems[x].ToString() + "\n";
                }

                MessageBox.Show("Книга успешно добавлена!");
            }
            else
            {
                MessageBox.Show("Вы не заполнили все поля!");
                return;
            }
            Hide();
            MenuForm menu = new MenuForm();
            menu.ShowDialog();
            Show();
            menu.Close();
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void login_in_find_Field_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!Error_Debugger.Is_Number_Valide(login_in_find_Field.Text, out errorMsg))
            {
                e.Cancel = true;
                login_in_find_Field.Select(0, login_in_find_Field.Text.Length);
                this.errorProvider1.SetError(login_in_find_Field, errorMsg);
            }
        }

        private void login_in_find_Field_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(login_in_find_Field, "");
        }

        private void Findknown_bookForm_Load(object sender, EventArgs e)
        {
            Dictionary<int, Clients> dictionary;
            List<Books> list;
            (dictionary, list) = Serialization.Deserialize();
            foreach (Books book in list) 
            {
                switch (filterType)
                {
                    case 0:
                        if (book.name.Contains(filters))
                            all_bookcheckedListBox.Items.Add(book.name + ' ' + book.author + ' ' + book.date_of_publishing.ToShortDateString());
                        break;
                    case 1:
                        if (book.author.Contains(filters))
                            all_bookcheckedListBox.Items.Add(book.name + ' ' + book.author + ' ' + book.date_of_publishing.ToShortDateString());
                        break;
                    case 2:
                        if (book.date_of_publishing.Year == Convert.ToInt32(filters))
                            all_bookcheckedListBox.Items.Add(book.name + ' ' + book.author + ' ' + book.date_of_publishing.ToShortDateString());
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = login_in_find_Field.Text;
            Clients client = Library.GetClient(login);

            if (client is null)
            {
                MessageBox.Show("Такого клиента не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Recordings recording in client.Carta.Recordings)
            {
                if (!recording.IsAvailable && !checkedListBox1.Items.Contains(recording.Books))
                    checkedListBox1.Items.Add(recording.Books);
            }
        }


    }
}

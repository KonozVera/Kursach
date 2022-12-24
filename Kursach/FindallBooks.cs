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
    public partial class FindallBooks : Form
    {

        public FindallBooks()
        {
            InitializeComponent();

        }

        private void outButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
            Clients client = Library.GetClient(login_in_find_Field.Text);
            if (all_bookcheckedListBox.CheckedItems.Count != 0 && client != null)
            {
                string s = "";
                for (int x = 0; x < all_bookcheckedListBox.CheckedItems.Count; x++)
                {
                    //s = s + (x + 1).ToString() + all_bookcheckedListBox.CheckedItems[x].ToString() + "\n";
                    Library.Get_Book(client, all_bookcheckedListBox.CheckedItems[x] as Books);

                }
                String.Concat(' ', all_bookcheckedListBox.CheckedItems);
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

        private void FindallBooks_Load(object sender, EventArgs e)
        {
            //Dictionary<int, Clients> dictionary;
            //List<Books> list;
            //(dictionary, list) = Serialization.Deserialize();

            foreach (Books book in Library.Books)
            {
                all_bookcheckedListBox.Items.Add(book);
            }
        }
    }

}

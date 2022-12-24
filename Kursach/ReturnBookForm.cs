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
            if (login_in_find_Field.Text == "")
            {
                MessageBox.Show("Вы не заполнили все поля!");
                return;
            }

            Clients client = Library.GetClient(login_in_find_Field.Text);
            if (checkedListBox1.CheckedItems.Count != 0 && client != null)
            {
                string s = "";
                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {
                    //s = s + (x + 1).ToString() + checkedListBox1.CheckedItems[x].ToString() + "\n";

                    Library.Pass_Book(checkedListBox1.CheckedItems[x] as Books, client);
                    checkedListBox1.Items.RemoveAt(x);
                }
                MessageBox.Show("Книга успешно добавлена!");
            }
            else
            {
                //int Key = Convert.ToInt32(checkedListBox1.Text);
                string number = login_in_find_Field.Text;
                //Library.Pass_Book(Key, number);
                //string Name = "";
                //string author = "";
                //DateTime date_of_publishing = DateTime.Parse(year_publication_textBox.Text);
                //int number_of_copies = Convert.ToInt32(number_of_booksTextBox.Text);
                //int kol_vo_vzyat = 0;
                //List<Books> list;
                //Dictionary<int, Clients> dict;
                //(dict, list) = Serialization.Deserialize();
                //Books book = new Books(list[list.Count - 1].Key + 1, Name, author, date_of_publishing, number_of_copies, kol_vo_vzyat, list[list.Count - 1].Kol_vo_vsego + 1);
                //list.Add(book);
                //Serialization.Serialisation(dict, list);
                //this.DialogResult = DialogResult.OK;
                MessageBox.Show("Книга успешно возвращена!");
                this.DialogResult = DialogResult.OK;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            string login = login_in_find_Field.Text;
            Clients client = Library.GetClient(login);

            if (client is null)
            {
                return;
            }

            foreach (Recordings recording in client.Carta.Recordings)
            {
                if (!recording.IsAvailable && !checkedListBox1.Items.Contains(recording.Books))
                    checkedListBox1.Items.Add(recording.Books);
            }
        }

        private void checkedListBox1_Validating(object sender, CancelEventArgs e)
        {

        }



        //private void ReturnBookForm_Load(object sender, EventArgs e)
        //{
        //    Dictionary<int, Clients> dictionary;
        //    List<Books> list;
        //    (dictionary, list) = Serialization.Deserialize();
        //    foreach (Books book in list)
        //    {
        //        if (book.Key.Equals(filters))
        //            index_textBox.Add(book.name + ' ' + book.author + ' ' + book.date_of_publishing);



        //    }
        //}
    }
}

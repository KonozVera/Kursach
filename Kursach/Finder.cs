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
    public partial class Finder : Form
    {
        public Finder()
        {
            InitializeComponent();
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void anotherfinderButton_Click(object sender, EventArgs e)
        {
            Hide();
            FindallBooks findallbooks = new FindallBooks();
            findallbooks.ShowDialog();
            Show();
            findallbooks.Close();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Hide();
            Findknown_bookForm findknownbook = new Findknown_bookForm();
            findknownbook.ShowDialog();
            Show();
            findknownbook.Close();
        }

    }
}

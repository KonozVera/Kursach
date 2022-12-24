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
    public partial class ListofdebtorsForm : Form
    {
        public ListofdebtorsForm()
        {
            InitializeComponent();
        }

        private void return_menuButton_Click(object sender, EventArgs e)
        {
            Hide();
            MenuForm menu = new MenuForm();
            menu.ShowDialog();
            Show();
            menu.Close();
        }

        private void ListofdebtorsForm_Load(object sender, EventArgs e)
        {
            Recordings.ReferenceEquals(this, (ListofdebtorsForm)sender);
        }
    } 
}

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
    public partial class SraristicForm : Form
    {
        public SraristicForm()
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

        private void list_debtors_seeButton_Click(object sender, EventArgs e)
        {
            Hide();
            ListofdebtorsForm listofdebtors = new ListofdebtorsForm();
            listofdebtors.ShowDialog();
            Show();
            listofdebtors.Close();
        }
    }
}

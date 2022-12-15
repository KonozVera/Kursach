using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void login_in_reg_Field_Enter(object sender, EventArgs e)
        {
            if (login_in_reg_Field.Text == "Введите логин")
            {
                login_in_reg_Field.Text = String.Empty;
            }
        }

        private void login_in_reg_Field_Leave(object sender, EventArgs e)
        {
            if (login_in_reg_Field.Text == String.Empty)
            {
                login_in_reg_Field.Text = "Введите логин";
            }
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text == "Введите имя")
            {
                nameBox.Text = String.Empty;
            }
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == String.Empty)
            {
                nameBox.Text = "Введите имя";
            }
        }

        private void surnameBox_Enter(object sender, EventArgs e)
        {
            if (surnameBox.Text == "Введите фамилию")
            {
                surnameBox.Text = String.Empty;
            }
        }

        private void surnameBox_Leave(object sender, EventArgs e)
        {
            if (surnameBox.Text == String.Empty)
            {
                surnameBox.Text = "Введите фамилию";
            }
        }
    }
}

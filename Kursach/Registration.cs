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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (nameBox.Text == "Введите имя" || surnameBox.Text == "Введите фамилию" || employmentComboBox1.SelectedIndex == -1)
            {
                 MessageBox.Show("Вы не заполнили все поля!");
                    return;
            }

            if (!string.IsNullOrWhiteSpace(login_in_reg_Field.Text))
                switch (employmentComboBox1.Items[employmentComboBox1.SelectedIndex])
                {
                    case "TEACHER":
                        if (login_in_reg_Field.Text[0] == 'T')
                            this.DialogResult = DialogResult.OK;
                        break;
                    case "STUDENT":
                        if (login_in_reg_Field.Text[0] == 'S')
                            this.DialogResult = DialogResult.OK;
                        break;
                    default:
                        break;

                }
            errorProvider1.SetError(regButton, "Произошла ошибка!");
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

        private void nameBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!Error_Debugger.CheckString(nameBox.Text, out errorMsg))
            {
                e.Cancel = true;
                nameBox.Select(0, nameBox.Text.Length);
                this.errorProvider1.SetError(nameBox, errorMsg);
            }
        }

        private void surnameBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!Error_Debugger.CheckString(surnameBox.Text, out errorMsg))
            {
                e.Cancel = true;
                surnameBox.Select(0, surnameBox.Text.Length);
                this.errorProvider1.SetError(surnameBox, errorMsg);
            }
        }

        private void login_in_reg_Field_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!Error_Debugger.Is_Number_Valide(login_in_reg_Field.Text, out errorMsg))
            {
                e.Cancel = true;
                login_in_reg_Field.Select(0, login_in_reg_Field.Text.Length);
                this.errorProvider1.SetError(login_in_reg_Field, errorMsg);
            }
        }

        private void nameBox_Validated(object sender, EventArgs e)
        {
                errorProvider1.SetError(nameBox, "");
        }

        private void surnameBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(surnameBox, "");
        }

        private void login_in_reg_Field_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(login_in_reg_Field, "");
        }
    }
}

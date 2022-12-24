using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            if (FinderComboBox.SelectedIndex == -1)
            { 
                MessageBox.Show("Вы не выбрали каким образом осуществлять поиск!");
                return;
            }
            
            string errorMsg = "";
            int type = -1;
            if (!string.IsNullOrWhiteSpace(inputBox.Text))
                switch (FinderComboBox.Items[FinderComboBox.SelectedIndex])
                {
                    case "названию":
                        type = 0;
                        break;
                    case "автору":
                        type = 1;
                        if (!Error_Debugger.CheckStringAthor_finder(inputBox.Text, out errorMsg))
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "году издания":
                        type = 2;
                        if (!Error_Debugger.CheckYear(inputBox.Text, out errorMsg))
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    default:
                        type = -1;
                        break;
                }
            else
            {
                errorProvider1.SetError(findButton, "Произошла ошибка!");
            }
            Hide();
            Findknown_bookForm findknownbook = new Findknown_bookForm(inputBox.Text,type);
            findknownbook.ShowDialog();
            Show();
            findknownbook.Close();
        }

        private void inputBox_Validating(object sender, CancelEventArgs e)
        {
            if (FinderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали каким образом осуществлять поиск!");
                return;
            }
            string errorMsg = "";
            switch (FinderComboBox.Items[FinderComboBox.SelectedIndex])
            {
                case "названию":
                    break;
                case "автору":
                    if (!Error_Debugger.CheckStringAthor_finder(inputBox.Text, out errorMsg))
                        e.Cancel = true;
                    inputBox.Select(0, inputBox.Text.Length);
                    this.errorProvider1.SetError(inputBox, errorMsg);
                    break;
                case "году издания":
                    if (!Error_Debugger.CheckYear(inputBox.Text, out errorMsg))
                        e.Cancel = true;
                    inputBox.Select(0, inputBox.Text.Length);
                    this.errorProvider1.SetError(inputBox, errorMsg);
                    break;
                default:
                    break;
            }
        }

        private void inputBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(inputBox, "");
        }

        private void additionalinputBox_Validating(object sender, CancelEventArgs e)
        {
            if (additional_finderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали каким образом осуществлять поиск!");
                return;
            }
            
            string errorMsg = "";
            switch (additional_finderComboBox.Items[additional_finderComboBox.SelectedIndex])
            {
                case "названию":
                    break;
                case "автору":
                    if (!Error_Debugger.CheckStringAthor_finder(additionalinputBox.Text, out errorMsg))
                        e.Cancel = true;
                    additionalinputBox.Select(0, additionalinputBox.Text.Length);
                    this.errorProvider1.SetError(additionalinputBox, errorMsg);
                    break;
                case "году издания":
                    if (!Error_Debugger.CheckYear(additionalinputBox.Text, out errorMsg))
                        e.Cancel = true;
                    additionalinputBox.Select(0, additionalinputBox.Text.Length);
                    this.errorProvider1.SetError(additionalinputBox, errorMsg);
                    break;
                default:
                    break;
            }
        }

        private void additionalinputBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(additionalinputBox, "");
        }

        //private void Finder_Load(object sender, EventArgs e)
        //{
            
        //}
    }
}
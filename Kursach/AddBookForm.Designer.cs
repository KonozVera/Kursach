namespace Kursach
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.key = new System.Windows.Forms.TextBox();
            this.number_of_booksTextBox = new System.Windows.Forms.TextBox();
            this.athor_book_textBox = new System.Windows.Forms.TextBox();
            this.year_publication_textBox = new System.Windows.Forms.TextBox();
            this.name_book_textBox = new System.Windows.Forms.TextBox();
            this.addbookButton = new System.Windows.Forms.Button();
            this.return_menuButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(144)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.key);
            this.panel1.Controls.Add(this.number_of_booksTextBox);
            this.panel1.Controls.Add(this.athor_book_textBox);
            this.panel1.Controls.Add(this.year_publication_textBox);
            this.panel1.Controls.Add(this.name_book_textBox);
            this.panel1.Controls.Add(this.addbookButton);
            this.panel1.Controls.Add(this.return_menuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 469);
            this.panel1.TabIndex = 0;
            // 
            // key
            // 
            this.key.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key.Location = new System.Drawing.Point(36, 343);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(677, 44);
            this.key.TabIndex = 41;
            this.key.Text = "Введите индекс книги";
            this.key.Enter += new System.EventHandler(this.key_Enter);
            this.key.Leave += new System.EventHandler(this.key_Leave);
            this.key.Validating += new System.ComponentModel.CancelEventHandler(this.key_Validating);
            this.key.Validated += new System.EventHandler(this.key_Validated);
            // 
            // number_of_booksTextBox
            // 
            this.number_of_booksTextBox.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_booksTextBox.Location = new System.Drawing.Point(36, 260);
            this.number_of_booksTextBox.Name = "number_of_booksTextBox";
            this.number_of_booksTextBox.Size = new System.Drawing.Size(677, 44);
            this.number_of_booksTextBox.TabIndex = 40;
            this.number_of_booksTextBox.Text = "Введите количество экземпляров книги";
            this.number_of_booksTextBox.Enter += new System.EventHandler(this.number_of_booksTextBox_Enter);
            this.number_of_booksTextBox.Leave += new System.EventHandler(this.number_of_booksTextBox_Leave);
            this.number_of_booksTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.number_of_booksTextBox_Validating);
            this.number_of_booksTextBox.Validated += new System.EventHandler(this.number_of_booksTextBox_Validated);
            // 
            // athor_book_textBox
            // 
            this.athor_book_textBox.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.athor_book_textBox.Location = new System.Drawing.Point(36, 95);
            this.athor_book_textBox.Name = "athor_book_textBox";
            this.athor_book_textBox.Size = new System.Drawing.Size(677, 44);
            this.athor_book_textBox.TabIndex = 39;
            this.athor_book_textBox.Text = "Введите автора книги";
            this.athor_book_textBox.Enter += new System.EventHandler(this.athor_book_textBox_Enter);
            this.athor_book_textBox.Leave += new System.EventHandler(this.athor_book_textBox_Leave);
            this.athor_book_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.athor_book_textBox_Validating);
            this.athor_book_textBox.Validated += new System.EventHandler(this.athor_book_textBox_Validated);
            // 
            // year_publication_textBox
            // 
            this.year_publication_textBox.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_publication_textBox.Location = new System.Drawing.Point(36, 177);
            this.year_publication_textBox.Name = "year_publication_textBox";
            this.year_publication_textBox.Size = new System.Drawing.Size(677, 44);
            this.year_publication_textBox.TabIndex = 38;
            this.year_publication_textBox.Text = "Введите год издания";
            this.year_publication_textBox.Enter += new System.EventHandler(this.year_publication_textBox_Enter);
            this.year_publication_textBox.Leave += new System.EventHandler(this.year_publication_textBox_Leave);
            this.year_publication_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.year_publication_textBox_Validating);
            this.year_publication_textBox.Validated += new System.EventHandler(this.year_publication_textBox_Validated);
            // 
            // name_book_textBox
            // 
            this.name_book_textBox.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_book_textBox.Location = new System.Drawing.Point(36, 12);
            this.name_book_textBox.Name = "name_book_textBox";
            this.name_book_textBox.Size = new System.Drawing.Size(677, 44);
            this.name_book_textBox.TabIndex = 37;
            this.name_book_textBox.Text = "Введите название книги";
            this.name_book_textBox.Enter += new System.EventHandler(this.name_book_textBox_Enter);
            this.name_book_textBox.Leave += new System.EventHandler(this.name_book_textBox_Leave);
            this.name_book_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.name_book_textBox_Validating);
            this.name_book_textBox.Validated += new System.EventHandler(this.name_book_textBox_Validated);
            // 
            // addbookButton
            // 
            this.addbookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(169)))), ((int)(((byte)(114)))));
            this.addbookButton.FlatAppearance.BorderSize = 0;
            this.addbookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbookButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbookButton.Location = new System.Drawing.Point(526, 411);
            this.addbookButton.Name = "addbookButton";
            this.addbookButton.Size = new System.Drawing.Size(250, 36);
            this.addbookButton.TabIndex = 33;
            this.addbookButton.Text = "Добавить";
            this.addbookButton.UseVisualStyleBackColor = false;
            this.addbookButton.Click += new System.EventHandler(this.addbookButton_Click);
            // 
            // return_menuButton
            // 
            this.return_menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(169)))), ((int)(((byte)(114)))));
            this.return_menuButton.FlatAppearance.BorderSize = 0;
            this.return_menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_menuButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_menuButton.Location = new System.Drawing.Point(250, 411);
            this.return_menuButton.Name = "return_menuButton";
            this.return_menuButton.Size = new System.Drawing.Size(250, 36);
            this.return_menuButton.TabIndex = 32;
            this.return_menuButton.Text = "Перейти в меню";
            this.return_menuButton.UseVisualStyleBackColor = false;
            this.return_menuButton.Click += new System.EventHandler(this.return_menuButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addbookButton;
        private System.Windows.Forms.Button return_menuButton;
        private System.Windows.Forms.TextBox athor_book_textBox;
        private System.Windows.Forms.TextBox year_publication_textBox;
        private System.Windows.Forms.TextBox name_book_textBox;
        private System.Windows.Forms.TextBox number_of_booksTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox key;
    }
}
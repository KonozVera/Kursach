namespace Kursach
{
    partial class ReturnBookForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.returnbookButton = new System.Windows.Forms.Button();
            this.return_menuButton = new System.Windows.Forms.Button();
            this.index_textBox = new System.Windows.Forms.TextBox();
            this.login_in_find_Field = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.returnbookButton);
            this.panel1.Controls.Add(this.return_menuButton);
            this.panel1.Controls.Add(this.index_textBox);
            this.panel1.Controls.Add(this.login_in_find_Field);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
         
            // 
            // returnbookButton
            // 
            this.returnbookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(169)))), ((int)(((byte)(114)))));
            this.returnbookButton.FlatAppearance.BorderSize = 0;
            this.returnbookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbookButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnbookButton.Location = new System.Drawing.Point(529, 402);
            this.returnbookButton.Name = "returnbookButton";
            this.returnbookButton.Size = new System.Drawing.Size(250, 36);
            this.returnbookButton.TabIndex = 31;
            this.returnbookButton.Text = "Вернуть";
            this.returnbookButton.UseVisualStyleBackColor = false;
            this.returnbookButton.Click += new System.EventHandler(this.returnbookButton_Click);
            // 
            // return_menuButton
            // 
            this.return_menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(169)))), ((int)(((byte)(114)))));
            this.return_menuButton.FlatAppearance.BorderSize = 0;
            this.return_menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_menuButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_menuButton.Location = new System.Drawing.Point(249, 402);
            this.return_menuButton.Name = "return_menuButton";
            this.return_menuButton.Size = new System.Drawing.Size(250, 36);
            this.return_menuButton.TabIndex = 30;
            this.return_menuButton.Text = "Перейти в меню";
            this.return_menuButton.UseVisualStyleBackColor = false;
            this.return_menuButton.Click += new System.EventHandler(this.return_menuButton_Click);
            // 
            // index_textBox
            // 
            this.index_textBox.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.index_textBox.Location = new System.Drawing.Point(403, 12);
            this.index_textBox.Name = "index_textBox";
            this.index_textBox.Size = new System.Drawing.Size(313, 44);
            this.index_textBox.TabIndex = 29;
            this.index_textBox.Text = "Введите индекс книги";
            this.index_textBox.Enter += new System.EventHandler(this.index_textBox_Enter);
            this.index_textBox.Leave += new System.EventHandler(this.index_textBox_Leave);
            // 
            // login_in_find_Field
            // 
            this.login_in_find_Field.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_in_find_Field.Location = new System.Drawing.Point(106, 12);
            this.login_in_find_Field.Name = "login_in_find_Field";
            this.login_in_find_Field.Size = new System.Drawing.Size(257, 44);
            this.login_in_find_Field.TabIndex = 28;
            this.login_in_find_Field.Text = "Введите логин";
            this.login_in_find_Field.Enter += new System.EventHandler(this.login_in_find_Field_Enter);
            this.login_in_find_Field.Leave += new System.EventHandler(this.login_in_find_Field_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button returnbookButton;
        private System.Windows.Forms.Button return_menuButton;
        private System.Windows.Forms.TextBox index_textBox;
        private System.Windows.Forms.TextBox login_in_find_Field;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
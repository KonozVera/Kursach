namespace Kursach
{
    partial class Findknown_bookForm
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
            this.Fonpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.all_bookcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.add_bookButton = new System.Windows.Forms.Button();
            this.login_in_find_Field = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.outButton = new System.Windows.Forms.Button();
            this.additionalLabel = new System.Windows.Forms.Label();
            this.Fonpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Fonpanel
            // 
            this.Fonpanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Fonpanel.Controls.Add(this.label1);
            this.Fonpanel.Controls.Add(this.all_bookcheckedListBox);
            this.Fonpanel.Controls.Add(this.add_bookButton);
            this.Fonpanel.Controls.Add(this.login_in_find_Field);
            this.Fonpanel.Controls.Add(this.pictureBox1);
            this.Fonpanel.Controls.Add(this.outButton);
            this.Fonpanel.Controls.Add(this.additionalLabel);
            this.Fonpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fonpanel.Location = new System.Drawing.Point(0, 0);
            this.Fonpanel.Name = "Fonpanel";
            this.Fonpanel.Size = new System.Drawing.Size(800, 450);
            this.Fonpanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Список книг:";
            // 
            // all_bookcheckedListBox
            // 
            this.all_bookcheckedListBox.FormattingEnabled = true;
            this.all_bookcheckedListBox.Items.AddRange(new object[] {
            "\"Ала\" А. А. Ало 1997"});
            this.all_bookcheckedListBox.Location = new System.Drawing.Point(9, 153);
            this.all_bookcheckedListBox.Name = "all_bookcheckedListBox";
            this.all_bookcheckedListBox.Size = new System.Drawing.Size(299, 89);
            this.all_bookcheckedListBox.TabIndex = 28;
            this.all_bookcheckedListBox.Tag = "";
            // 
            // add_bookButton
            // 
            this.add_bookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(153)))), ((int)(((byte)(107)))));
            this.add_bookButton.FlatAppearance.BorderSize = 0;
            this.add_bookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_bookButton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_bookButton.Location = new System.Drawing.Point(407, 12);
            this.add_bookButton.Name = "add_bookButton";
            this.add_bookButton.Size = new System.Drawing.Size(186, 50);
            this.add_bookButton.TabIndex = 27;
            this.add_bookButton.Text = "Добавить";
            this.add_bookButton.UseVisualStyleBackColor = false;
            this.add_bookButton.Click += new System.EventHandler(this.add_bookButton_Click);
            // 
            // login_in_find_Field
            // 
            this.login_in_find_Field.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_in_find_Field.Location = new System.Drawing.Point(118, 12);
            this.login_in_find_Field.Name = "login_in_find_Field";
            this.login_in_find_Field.Size = new System.Drawing.Size(257, 44);
            this.login_in_find_Field.TabIndex = 26;
            this.login_in_find_Field.Text = "Введите логин";
          
            this.login_in_find_Field.Enter += new System.EventHandler(this.login_in_find_Field_Enter);
            this.login_in_find_Field.Leave += new System.EventHandler(this.login_in_find_Field_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
         
            // 
            // outButton
            // 
            this.outButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(124)))), ((int)(((byte)(91)))));
            this.outButton.FlatAppearance.BorderSize = 0;
            this.outButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outButton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outButton.Location = new System.Drawing.Point(599, 12);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(186, 50);
            this.outButton.TabIndex = 24;
            this.outButton.Text = "Вернуться";
            this.outButton.UseVisualStyleBackColor = false;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // additionalLabel
            // 
            this.additionalLabel.AutoSize = true;
            this.additionalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.additionalLabel.Location = new System.Drawing.Point(13, 176);
            this.additionalLabel.Name = "additionalLabel";
            this.additionalLabel.Size = new System.Drawing.Size(0, 18);
            this.additionalLabel.TabIndex = 23;
            // 
            // Findknown_bookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fonpanel);
            this.Name = "Findknown_bookForm";
            this.Text = "Findknown_bookForm";
            this.Fonpanel.ResumeLayout(false);
            this.Fonpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Fonpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox all_bookcheckedListBox;
        private System.Windows.Forms.Button add_bookButton;
        private System.Windows.Forms.TextBox login_in_find_Field;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.Label additionalLabel;
    }
}
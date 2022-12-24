namespace Kursach
{
    partial class ListofdebtorsForm
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
            this.send_newsletterButton = new System.Windows.Forms.Button();
            this.return_menuButton = new System.Windows.Forms.Button();
            this.borrowed_bookLabel = new System.Windows.Forms.Label();
            this.debtorsListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(97)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.send_newsletterButton);
            this.panel1.Controls.Add(this.return_menuButton);
            this.panel1.Controls.Add(this.borrowed_bookLabel);
            this.panel1.Controls.Add(this.debtorsListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // send_newsletterButton
            // 
            this.send_newsletterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(169)))), ((int)(((byte)(114)))));
            this.send_newsletterButton.FlatAppearance.BorderSize = 0;
            this.send_newsletterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_newsletterButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send_newsletterButton.Location = new System.Drawing.Point(499, 402);
            this.send_newsletterButton.Name = "send_newsletterButton";
            this.send_newsletterButton.Size = new System.Drawing.Size(250, 36);
            this.send_newsletterButton.TabIndex = 43;
            this.send_newsletterButton.Text = "Отправить рассылку";
            this.send_newsletterButton.UseVisualStyleBackColor = false;
         
            // 
            // return_menuButton
            // 
            this.return_menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(169)))), ((int)(((byte)(114)))));
            this.return_menuButton.FlatAppearance.BorderSize = 0;
            this.return_menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_menuButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_menuButton.Location = new System.Drawing.Point(12, 402);
            this.return_menuButton.Name = "return_menuButton";
            this.return_menuButton.Size = new System.Drawing.Size(250, 36);
            this.return_menuButton.TabIndex = 42;
            this.return_menuButton.Text = "Перейти в меню";
            this.return_menuButton.UseVisualStyleBackColor = false;
            this.return_menuButton.Click += new System.EventHandler(this.return_menuButton_Click);
            // 
            // borrowed_bookLabel
            // 
            this.borrowed_bookLabel.AutoSize = true;
            this.borrowed_bookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borrowed_bookLabel.Location = new System.Drawing.Point(12, 21);
            this.borrowed_bookLabel.Name = "borrowed_bookLabel";
            this.borrowed_bookLabel.Size = new System.Drawing.Size(194, 22);
            this.borrowed_bookLabel.TabIndex = 41;
            this.borrowed_bookLabel.Text = "Список задолжников:";
            // 
            // debtorsListBox
            // 
            this.debtorsListBox.FormattingEnabled = true;
            this.debtorsListBox.ItemHeight = 16;
            this.debtorsListBox.Items.AddRange(new object[] {
            "Ладун В. С. \"Лошадь\" Т. Р. Куприн 2004"});
            this.debtorsListBox.Location = new System.Drawing.Point(12, 56);
            this.debtorsListBox.Name = "debtorsListBox";
            this.debtorsListBox.Size = new System.Drawing.Size(622, 292);
            this.debtorsListBox.TabIndex = 0;
            // 
            // ListofdebtorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListofdebtorsForm";
            this.Text = "ListofdebtorsForm";
            this.Load += new System.EventHandler(this.ListofdebtorsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox debtorsListBox;
        private System.Windows.Forms.Label borrowed_bookLabel;
        private System.Windows.Forms.Button send_newsletterButton;
        private System.Windows.Forms.Button return_menuButton;
    }
}
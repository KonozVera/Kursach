namespace Kursach
{
    partial class DeleteForm
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
            this.Fonpanel = new System.Windows.Forms.Panel();
            this.indexLabel = new System.Windows.Forms.Label();
            this.deletebookButton = new System.Windows.Forms.Button();
            this.return_menuButton = new System.Windows.Forms.Button();
            this.index_textBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Fonpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Fonpanel
            // 
            this.Fonpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(114)))), ((int)(((byte)(214)))));
            this.Fonpanel.Controls.Add(this.indexLabel);
            this.Fonpanel.Controls.Add(this.deletebookButton);
            this.Fonpanel.Controls.Add(this.return_menuButton);
            this.Fonpanel.Controls.Add(this.index_textBox);
            this.Fonpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fonpanel.Location = new System.Drawing.Point(0, 0);
            this.Fonpanel.Name = "Fonpanel";
            this.Fonpanel.Size = new System.Drawing.Size(800, 450);
            this.Fonpanel.TabIndex = 0;
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexLabel.Location = new System.Drawing.Point(240, 98);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(342, 18);
            this.indexLabel.TabIndex = 35;
            this.indexLabel.Text = "Введите индекс книги, которую хотите удалить:";
            // 
            // deletebookButton
            // 
            this.deletebookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(169)))), ((int)(((byte)(114)))));
            this.deletebookButton.FlatAppearance.BorderSize = 0;
            this.deletebookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebookButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletebookButton.Location = new System.Drawing.Point(433, 251);
            this.deletebookButton.Name = "deletebookButton";
            this.deletebookButton.Size = new System.Drawing.Size(250, 36);
            this.deletebookButton.TabIndex = 34;
            this.deletebookButton.Text = "Удалить";
            this.deletebookButton.UseVisualStyleBackColor = false;
            this.deletebookButton.Click += new System.EventHandler(this.deletebookButton_Click);
            // 
            // return_menuButton
            // 
            this.return_menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(169)))), ((int)(((byte)(114)))));
            this.return_menuButton.FlatAppearance.BorderSize = 0;
            this.return_menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_menuButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_menuButton.Location = new System.Drawing.Point(120, 251);
            this.return_menuButton.Name = "return_menuButton";
            this.return_menuButton.Size = new System.Drawing.Size(250, 36);
            this.return_menuButton.TabIndex = 33;
            this.return_menuButton.Text = "Перейти в меню";
            this.return_menuButton.UseVisualStyleBackColor = false;
            this.return_menuButton.Click += new System.EventHandler(this.return_menuButton_Click);
            // 
            // index_textBox
            // 
            this.index_textBox.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.index_textBox.Location = new System.Drawing.Point(243, 132);
            this.index_textBox.Name = "index_textBox";
            this.index_textBox.Size = new System.Drawing.Size(328, 44);
            this.index_textBox.TabIndex = 32;
            this.index_textBox.Text = "Введите индекс книги";
            this.index_textBox.Enter += new System.EventHandler(this.index_textBox_Enter);
            this.index_textBox.Leave += new System.EventHandler(this.index_textBox_Leave);
            this.index_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.index_textBox_Validating);
            this.index_textBox.Validated += new System.EventHandler(this.index_textBox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fonpanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.Fonpanel.ResumeLayout(false);
            this.Fonpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Fonpanel;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Button deletebookButton;
        private System.Windows.Forms.Button return_menuButton;
        private System.Windows.Forms.TextBox index_textBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
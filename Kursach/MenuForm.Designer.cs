namespace Kursach
{
    partial class MenuForm
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
            this.fonPanel = new System.Windows.Forms.Panel();
            this.add_book_Button = new System.Windows.Forms.Button();
            this.view_statistics_Button = new System.Windows.Forms.Button();
            this.return_book_Button = new System.Windows.Forms.Button();
            this.delete_book_Button = new System.Windows.Forms.Button();
            this.burn_book_Button = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.libraryLabel = new System.Windows.Forms.Label();
            this.fonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fonPanel
            // 
            this.fonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(70)))), ((int)(((byte)(176)))));
            this.fonPanel.Controls.Add(this.add_book_Button);
            this.fonPanel.Controls.Add(this.view_statistics_Button);
            this.fonPanel.Controls.Add(this.return_book_Button);
            this.fonPanel.Controls.Add(this.delete_book_Button);
            this.fonPanel.Controls.Add(this.burn_book_Button);
            this.fonPanel.Controls.Add(this.regButton);
            this.fonPanel.Controls.Add(this.label1);
            this.fonPanel.Controls.Add(this.libraryLabel);
            this.fonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fonPanel.Location = new System.Drawing.Point(0, 0);
            this.fonPanel.Name = "fonPanel";
            this.fonPanel.Size = new System.Drawing.Size(800, 450);
            this.fonPanel.TabIndex = 0;
            // 
            // add_book_Button
            // 
            this.add_book_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(242)))), ((int)(((byte)(48)))));
            this.add_book_Button.FlatAppearance.BorderSize = 0;
            this.add_book_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_book_Button.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_book_Button.Location = new System.Drawing.Point(541, 176);
            this.add_book_Button.Name = "add_book_Button";
            this.add_book_Button.Size = new System.Drawing.Size(223, 46);
            this.add_book_Button.TabIndex = 7;
            this.add_book_Button.Text = "Добавить книгу";
            this.add_book_Button.UseVisualStyleBackColor = false;
            this.add_book_Button.Click += new System.EventHandler(this.add_book_Button_Click);
            // 
            // view_statistics_Button
            // 
            this.view_statistics_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.view_statistics_Button.FlatAppearance.BorderSize = 0;
            this.view_statistics_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_statistics_Button.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.view_statistics_Button.Location = new System.Drawing.Point(541, 262);
            this.view_statistics_Button.Name = "view_statistics_Button";
            this.view_statistics_Button.Size = new System.Drawing.Size(223, 76);
            this.view_statistics_Button.TabIndex = 6;
            this.view_statistics_Button.Text = "Посмотреть статистику";
            this.view_statistics_Button.UseVisualStyleBackColor = false;
            this.view_statistics_Button.Click += new System.EventHandler(this.view_statistics_Button_Click);
            // 
            // return_book_Button
            // 
            this.return_book_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(48)))), ((int)(((byte)(148)))));
            this.return_book_Button.FlatAppearance.BorderSize = 0;
            this.return_book_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_book_Button.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_book_Button.Location = new System.Drawing.Point(12, 262);
            this.return_book_Button.Name = "return_book_Button";
            this.return_book_Button.Size = new System.Drawing.Size(223, 46);
            this.return_book_Button.TabIndex = 5;
            this.return_book_Button.Text = "Вернуть книгу";
            this.return_book_Button.UseVisualStyleBackColor = false;
            this.return_book_Button.Click += new System.EventHandler(this.return_book_Button_Click);
            // 
            // delete_book_Button
            // 
            this.delete_book_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(77)))), ((int)(((byte)(48)))));
            this.delete_book_Button.FlatAppearance.BorderSize = 0;
            this.delete_book_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_book_Button.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_book_Button.Location = new System.Drawing.Point(541, 91);
            this.delete_book_Button.Name = "delete_book_Button";
            this.delete_book_Button.Size = new System.Drawing.Size(223, 46);
            this.delete_book_Button.TabIndex = 4;
            this.delete_book_Button.Text = "Удалить книгу";
            this.delete_book_Button.UseVisualStyleBackColor = false;
            this.delete_book_Button.Click += new System.EventHandler(this.delete_book_Button_Click);
            // 
            // burn_book_Button
            // 
            this.burn_book_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(48)))), ((int)(((byte)(242)))));
            this.burn_book_Button.FlatAppearance.BorderSize = 0;
            this.burn_book_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.burn_book_Button.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.burn_book_Button.Location = new System.Drawing.Point(12, 176);
            this.burn_book_Button.Name = "burn_book_Button";
            this.burn_book_Button.Size = new System.Drawing.Size(223, 46);
            this.burn_book_Button.TabIndex = 3;
            this.burn_book_Button.Text = "Записать книгу";
            this.burn_book_Button.UseVisualStyleBackColor = false;
            this.burn_book_Button.Click += new System.EventHandler(this.burn_book_Button_Click);
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(242)))), ((int)(((byte)(48)))));
            this.regButton.FlatAppearance.BorderSize = 0;
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regButton.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.Location = new System.Drawing.Point(12, 91);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(223, 46);
            this.regButton.TabIndex = 2;
            this.regButton.Text = "Регистрация";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите функцию:";
            // 
            // libraryLabel
            // 
            this.libraryLabel.AutoSize = true;
            this.libraryLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.libraryLabel.Location = new System.Drawing.Point(196, 9);
            this.libraryLabel.Name = "libraryLabel";
            this.libraryLabel.Size = new System.Drawing.Size(424, 31);
            this.libraryLabel.TabIndex = 0;
            this.libraryLabel.Text = "Добро пожаловать в библиотеку!";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fonPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.fonPanel.ResumeLayout(false);
            this.fonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fonPanel;
        private System.Windows.Forms.Button add_book_Button;
        private System.Windows.Forms.Button view_statistics_Button;
        private System.Windows.Forms.Button return_book_Button;
        private System.Windows.Forms.Button delete_book_Button;
        private System.Windows.Forms.Button burn_book_Button;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label libraryLabel;
    }
}
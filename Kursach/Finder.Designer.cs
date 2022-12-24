namespace Kursach
{
    partial class Finder
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
            this.additionalinputBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.anotherfinderButton = new System.Windows.Forms.Button();
            this.anotherfinderLabel = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.outButton = new System.Windows.Forms.Button();
            this.additionalLabel = new System.Windows.Forms.Label();
            this.additional_finderComboBox = new System.Windows.Forms.ComboBox();
            this.FinderComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(215)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.additionalinputBox);
            this.panel1.Controls.Add(this.inputBox);
            this.panel1.Controls.Add(this.anotherfinderButton);
            this.panel1.Controls.Add(this.anotherfinderLabel);
            this.panel1.Controls.Add(this.findButton);
            this.panel1.Controls.Add(this.outButton);
            this.panel1.Controls.Add(this.additionalLabel);
            this.panel1.Controls.Add(this.additional_finderComboBox);
            this.panel1.Controls.Add(this.FinderComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // additionalinputBox
            // 
            this.additionalinputBox.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalinputBox.Location = new System.Drawing.Point(200, 100);
            this.additionalinputBox.Name = "additionalinputBox";
            this.additionalinputBox.Size = new System.Drawing.Size(219, 32);
            this.additionalinputBox.TabIndex = 15;
            this.additionalinputBox.Validating += new System.ComponentModel.CancelEventHandler(this.additionalinputBox_Validating);
            this.additionalinputBox.Validated += new System.EventHandler(this.additionalinputBox_Validated);
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(200, 12);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(219, 32);
            this.inputBox.TabIndex = 14;
            this.inputBox.Validating += new System.ComponentModel.CancelEventHandler(this.inputBox_Validating);
            this.inputBox.Validated += new System.EventHandler(this.inputBox_Validated);
            // 
            // anotherfinderButton
            // 
            this.anotherfinderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(91)))), ((int)(((byte)(222)))));
            this.anotherfinderButton.FlatAppearance.BorderSize = 0;
            this.anotherfinderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anotherfinderButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.anotherfinderButton.Location = new System.Drawing.Point(573, 44);
            this.anotherfinderButton.Name = "anotherfinderButton";
            this.anotherfinderButton.Size = new System.Drawing.Size(167, 29);
            this.anotherfinderButton.TabIndex = 10;
            this.anotherfinderButton.Text = "Жми!";
            this.anotherfinderButton.UseVisualStyleBackColor = false;
            this.anotherfinderButton.Click += new System.EventHandler(this.anotherfinderButton_Click);
            // 
            // anotherfinderLabel
            // 
            this.anotherfinderLabel.AutoSize = true;
            this.anotherfinderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.anotherfinderLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.anotherfinderLabel.Location = new System.Drawing.Point(564, 12);
            this.anotherfinderLabel.Name = "anotherfinderLabel";
            this.anotherfinderLabel.Size = new System.Drawing.Size(185, 18);
            this.anotherfinderLabel.TabIndex = 9;
            this.anotherfinderLabel.Text = "Не знаешь, что выбрать?";
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(222)))), ((int)(((byte)(200)))));
            this.findButton.FlatAppearance.BorderSize = 0;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.Location = new System.Drawing.Point(573, 409);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(167, 29);
            this.findButton.TabIndex = 6;
            this.findButton.Text = "Поиск";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // outButton
            // 
            this.outButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(124)))), ((int)(((byte)(91)))));
            this.outButton.FlatAppearance.BorderSize = 0;
            this.outButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outButton.Location = new System.Drawing.Point(16, 409);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(167, 29);
            this.outButton.TabIndex = 5;
            this.outButton.Text = "Назад";
            this.outButton.UseVisualStyleBackColor = false;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // additionalLabel
            // 
            this.additionalLabel.AutoSize = true;
            this.additionalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.additionalLabel.Location = new System.Drawing.Point(13, 78);
            this.additionalLabel.Name = "additionalLabel";
            this.additionalLabel.Size = new System.Drawing.Size(175, 18);
            this.additionalLabel.TabIndex = 4;
            this.additionalLabel.Text = "Дополнительный поиск";
            // 
            // additional_finderComboBox
            // 
            this.additional_finderComboBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additional_finderComboBox.FormattingEnabled = true;
            this.additional_finderComboBox.Items.AddRange(new object[] {
            "названию",
            "автору",
            "году издания"});
            this.additional_finderComboBox.Location = new System.Drawing.Point(12, 100);
            this.additional_finderComboBox.Name = "additional_finderComboBox";
            this.additional_finderComboBox.Size = new System.Drawing.Size(165, 30);
            this.additional_finderComboBox.TabIndex = 2;
            this.additional_finderComboBox.Text = "Найти книгу по: ";
            // 
            // FinderComboBox
            // 
            this.FinderComboBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinderComboBox.FormattingEnabled = true;
            this.FinderComboBox.Items.AddRange(new object[] {
            "названию",
            "автору",
            "году издания"});
            this.FinderComboBox.Location = new System.Drawing.Point(12, 12);
            this.FinderComboBox.Name = "FinderComboBox";
            this.FinderComboBox.Size = new System.Drawing.Size(165, 30);
            this.FinderComboBox.TabIndex = 0;
            this.FinderComboBox.Text = "Найти книгу по: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Finder";
            this.Text = "Finder";
          
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox FinderComboBox;
        private System.Windows.Forms.Label additionalLabel;
        private System.Windows.Forms.ComboBox additional_finderComboBox;
        private System.Windows.Forms.Button anotherfinderButton;
        private System.Windows.Forms.Label anotherfinderLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.TextBox additionalinputBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
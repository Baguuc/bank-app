namespace BankApp
{
    partial class LoginForm
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
            EmailInput = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            PasswordInput = new TextBox();
            SubmitButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // EmailInput
            // 
            EmailInput.Dock = DockStyle.Fill;
            EmailInput.Location = new Point(0, 0);
            EmailInput.Margin = new Padding(0);
            EmailInput.Name = "EmailInput";
            EmailInput.PlaceholderText = "Podaj swój email..";
            EmailInput.Size = new Size(200, 23);
            EmailInput.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(EmailInput, 0, 0);
            tableLayoutPanel1.Controls.Add(PasswordInput, 0, 1);
            tableLayoutPanel1.Controls.Add(SubmitButton, 0, 2);
            tableLayoutPanel1.Location = new Point(28, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // PasswordInput
            // 
            PasswordInput.Dock = DockStyle.Fill;
            PasswordInput.Location = new Point(0, 23);
            PasswordInput.Margin = new Padding(0);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.PlaceholderText = "Podaj swoje hasło";
            PasswordInput.Size = new Size(200, 23);
            PasswordInput.TabIndex = 1;
            // 
            // SubmitButton
            // 
            SubmitButton.Dock = DockStyle.Fill;
            SubmitButton.Location = new Point(3, 49);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(194, 48);
            SubmitButton.TabIndex = 2;
            SubmitButton.Text = "Zaloguj się";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += Submit;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 155);
            Controls.Add(tableLayoutPanel1);
            Name = "LoginForm";
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox EmailInput;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox PasswordInput;
        private Button SubmitButton;
    }
}
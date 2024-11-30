namespace BankApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            AmountLabel = new Label();
            NameLabel = new Label();
            AccountNoLabel = new Label();
            TransferButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(AmountLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(NameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(AccountNoLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(TransferButton, 0, 3);
            tableLayoutPanel1.Location = new Point(33, 38);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(200, 220);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Dock = DockStyle.Fill;
            AmountLabel.Location = new Point(3, 110);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(194, 55);
            AmountLabel.TabIndex = 2;
            AmountLabel.Text = "...";
            AmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Location = new Point(3, 55);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(194, 55);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Nazwa rachunku: ...";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AccountNoLabel
            // 
            AccountNoLabel.AutoSize = true;
            AccountNoLabel.Dock = DockStyle.Fill;
            AccountNoLabel.Location = new Point(3, 0);
            AccountNoLabel.Name = "AccountNoLabel";
            AccountNoLabel.Size = new Size(194, 55);
            AccountNoLabel.TabIndex = 0;
            AccountNoLabel.Text = "Numer rachunku: ...";
            AccountNoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TransferButton
            // 
            TransferButton.Dock = DockStyle.Fill;
            TransferButton.Location = new Point(3, 168);
            TransferButton.Name = "TransferButton";
            TransferButton.Size = new Size(194, 49);
            TransferButton.TabIndex = 3;
            TransferButton.Text = "Przelej pieniądze";
            TransferButton.UseVisualStyleBackColor = true;
            TransferButton.Click += CreateTransfer;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 291);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Bank";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label AccountNoLabel;
        private Label AmountLabel;
        private Label NameLabel;
        private Button TransferButton;
    }
}

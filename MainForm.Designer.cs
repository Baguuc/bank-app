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
            AccountDetailsContainer = new TableLayoutPanel();
            TransferButton = new Button();
            AccountNoLabel = new Label();
            NameLabel = new Label();
            AmountLabel = new Label();
            RootContainer = new TableLayoutPanel();
            TransferList = new ListBox();
            AccountDetailsContainer.SuspendLayout();
            RootContainer.SuspendLayout();
            SuspendLayout();
            // 
            // AccountDetailsContainer
            // 
            AccountDetailsContainer.ColumnCount = 1;
            AccountDetailsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AccountDetailsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            AccountDetailsContainer.Controls.Add(AmountLabel, 0, 2);
            AccountDetailsContainer.Controls.Add(NameLabel, 0, 1);
            AccountDetailsContainer.Controls.Add(AccountNoLabel, 0, 0);
            AccountDetailsContainer.Controls.Add(TransferButton, 0, 3);
            AccountDetailsContainer.Dock = DockStyle.Fill;
            AccountDetailsContainer.Location = new Point(3, 3);
            AccountDetailsContainer.Name = "AccountDetailsContainer";
            AccountDetailsContainer.RowCount = 4;
            AccountDetailsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            AccountDetailsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            AccountDetailsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            AccountDetailsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            AccountDetailsContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            AccountDetailsContainer.Size = new Size(243, 261);
            AccountDetailsContainer.TabIndex = 1;
            // 
            // TransferButton
            // 
            TransferButton.Dock = DockStyle.Fill;
            TransferButton.Location = new Point(3, 198);
            TransferButton.Name = "TransferButton";
            TransferButton.Size = new Size(237, 60);
            TransferButton.TabIndex = 3;
            TransferButton.Text = "Przelej pieniądze";
            TransferButton.UseVisualStyleBackColor = true;
            TransferButton.Click += CreateTransfer;
            // 
            // AccountNoLabel
            // 
            AccountNoLabel.AutoSize = true;
            AccountNoLabel.Dock = DockStyle.Fill;
            AccountNoLabel.Location = new Point(3, 0);
            AccountNoLabel.Name = "AccountNoLabel";
            AccountNoLabel.Size = new Size(237, 65);
            AccountNoLabel.TabIndex = 0;
            AccountNoLabel.Text = "Numer rachunku: ...";
            AccountNoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Location = new Point(3, 65);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(237, 65);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Nazwa rachunku: ...";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Dock = DockStyle.Fill;
            AmountLabel.Location = new Point(3, 130);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(237, 65);
            AmountLabel.TabIndex = 2;
            AmountLabel.Text = "...";
            AmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RootContainer
            // 
            RootContainer.ColumnCount = 2;
            RootContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            RootContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            RootContainer.Controls.Add(AccountDetailsContainer, 0, 0);
            RootContainer.Controls.Add(TransferList, 1, 0);
            RootContainer.Location = new Point(12, 12);
            RootContainer.Name = "RootContainer";
            RootContainer.RowCount = 1;
            RootContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            RootContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RootContainer.Size = new Size(498, 267);
            RootContainer.TabIndex = 4;
            // 
            // TransferList
            // 
            TransferList.Dock = DockStyle.Fill;
            TransferList.FormattingEnabled = true;
            TransferList.ImeMode = ImeMode.NoControl;
            TransferList.ItemHeight = 15;
            TransferList.Location = new Point(252, 3);
            TransferList.Name = "TransferList";
            TransferList.Size = new Size(243, 261);
            TransferList.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 291);
            Controls.Add(RootContainer);
            Name = "MainForm";
            Text = "Bank";
            Load += MainForm_Load;
            AccountDetailsContainer.ResumeLayout(false);
            AccountDetailsContainer.PerformLayout();
            RootContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel AccountDetailsContainer;
        private Label AmountLabel;
        private Label NameLabel;
        private Label AccountNoLabel;
        private Button TransferButton;
        private TableLayoutPanel RootContainer;
        private ListBox TransferList;
    }
}

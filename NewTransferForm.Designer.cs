namespace BankApp
{
    partial class NewTransferForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            AmountGroup = new GroupBox();
            AmountInput = new NumericUpDown();
            AccountNoGroup = new GroupBox();
            AccountNoInput = new NumericUpDown();
            CreateTransferButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            AmountGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AmountInput).BeginInit();
            AccountNoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AccountNoInput).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(AmountGroup, 0, 1);
            tableLayoutPanel1.Controls.Add(AccountNoGroup, 0, 0);
            tableLayoutPanel1.Controls.Add(CreateTransferButton, 0, 2);
            tableLayoutPanel1.Location = new Point(24, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(200, 182);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // AmountGroup
            // 
            AmountGroup.Controls.Add(AmountInput);
            AmountGroup.Location = new Point(3, 63);
            AmountGroup.Name = "AmountGroup";
            AmountGroup.Size = new Size(194, 54);
            AmountGroup.TabIndex = 2;
            AmountGroup.TabStop = false;
            AmountGroup.Text = "Wartość przelewu (w PLN)";
            // 
            // AmountInput
            // 
            AmountInput.Location = new Point(6, 25);
            AmountInput.Maximum = new decimal(new int[] { 1661992960, 1808227885, 5, 0 });
            AmountInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AmountInput.Name = "AmountInput";
            AmountInput.Size = new Size(182, 23);
            AmountInput.TabIndex = 1;
            AmountInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AccountNoGroup
            // 
            AccountNoGroup.Controls.Add(AccountNoInput);
            AccountNoGroup.Location = new Point(3, 3);
            AccountNoGroup.Name = "AccountNoGroup";
            AccountNoGroup.Size = new Size(194, 54);
            AccountNoGroup.TabIndex = 1;
            AccountNoGroup.TabStop = false;
            AccountNoGroup.Text = "Numer rachunku docelowego";
            // 
            // AccountNoInput
            // 
            AccountNoInput.Location = new Point(6, 25);
            AccountNoInput.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
            AccountNoInput.Name = "AccountNoInput";
            AccountNoInput.Size = new Size(182, 23);
            AccountNoInput.TabIndex = 1;
            // 
            // CreateTransferButton
            // 
            CreateTransferButton.Dock = DockStyle.Fill;
            CreateTransferButton.Location = new Point(3, 123);
            CreateTransferButton.Name = "CreateTransferButton";
            CreateTransferButton.Size = new Size(194, 56);
            CreateTransferButton.TabIndex = 2;
            CreateTransferButton.Text = "Przelej";
            CreateTransferButton.UseVisualStyleBackColor = true;
            CreateTransferButton.Click += SubmitTransfer;
            // 
            // NewTransferForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 236);
            Controls.Add(tableLayoutPanel1);
            Name = "NewTransferForm";
            Text = "Przelej pieniądze";
            tableLayoutPanel1.ResumeLayout(false);
            AmountGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AmountInput).EndInit();
            AccountNoGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AccountNoInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button CreateTransferButton;
        private NumericUpDown AccountNoInput;
        private GroupBox AccountNoGroup;
        private GroupBox AmountGroup;
        private NumericUpDown AmountInput;
    }
}
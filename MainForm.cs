using BankApp.HTTP;
using System.Net.Http.Headers;

namespace BankApp
{
    public partial class MainForm : Form
    {
        public string? token;
        private bool loginDialogLaunched = false;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void RefreshAccountDetails()
        {
            try
            {
                AccountDetails accountDetails = BankApi.GetAccountDetails(new AccountDetailsData(token!));

                // przeliczamy warto�� w groszach na z�ot�wki
                float amount = accountDetails.amount / 100;
                this.AccountNoLabel.Text = "Numer rachunku: " + accountDetails.accountNo;
                this.NameLabel.Text = "Nazwa rachunku: " + accountDetails.name;
                this.AmountLabel.Text = amount + "PLN";
            }
            catch (WrongTokenException)
            {
                MessageBox.Show("Wyst�pi� b��d podczas sprawdzania sesji logowania. Spr�buj zalogowa� si� ponownie.", "B��d sesji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginDialog = new LoginForm(this);

            if (!loginDialogLaunched)
            {
                loginDialog.ShowDialog();
                loginDialogLaunched = true;
            }

            if (this.token == null && !loginDialog.Enabled && this.loginDialogLaunched)
            {
                MessageBox.Show("Wyst�pi� b��d podczas sprawdzania sesji logowania. Spr�buj zalogowa� si� ponownie.", "B��d sesji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            RefreshAccountDetails();
        }

        private void CreateTransfer(object sender, EventArgs e)
        {
            (new NewTransferForm(this)).ShowDialog();
            RefreshAccountDetails();
        }
    }
}

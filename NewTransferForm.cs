using BankApp.HTTP;

namespace BankApp
{
    public partial class NewTransferForm : Form
    {
        private MainForm mainForm;

        public NewTransferForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void SubmitTransfer(object sender, EventArgs e)
        {
            try
            {
                //                                                                                          przeliczamy wartość w groszach na złotówki
                //                                                                                                                              ↓
                BankApi.CreateTransfer(new NewTransferData(this.mainForm.token, (int) this.AccountNoInput.Value, (int)this.AmountInput.Value * 100));
                this.Close();
            } catch (WrongTokenException)
            {
                MessageBox.Show("Wystąpił błąd podczas sprawdzania sesji logowania. Spróbuj zalogować się ponownie.", "Błąd sesji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (WrongTargetAccountException)
            {
                MessageBox.Show("Rachunek z takim numerem nie istnieje.", "Zły numer odbiorcy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (BalanceTooLowException)
            {
                MessageBox.Show("Nie posiadasz wystarczającej ilości pieniędzy na swoim rachunku aby wykonać ten przelew.", "Za mało pieniędzy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } catch (NegativeTransferAmountException)
            {
                MessageBox.Show("Nie można wykonywać przelewów z ujemną kwotą.", "Zła kwota", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

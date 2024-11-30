using System.Net.Mail;
using System.Text.Json;
using BankApp.HTTP;

namespace BankApp
{
    public partial class LoginForm : Form
    {
        private MainForm mainForm;

        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void Submit(object sender, EventArgs e)
        {
            // validujemy adres email
            try
            {
                MailAddress address = new MailAddress(this.EmailInput.Text);
            } catch(FormatException)
            {
                MessageBox.Show("Zły format adresu email", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = EmailInput.Text;
            string password = PasswordInput.Text;
            LoginData data = new LoginData(email, password);

            try
            {
                string token = BankApi.Login(data);

                mainForm.token = token;
                this.Close();
            } catch(WrongCredentialsException _)
            {
                MessageBox.Show("Wprowadzono złe dane logowania", "Złe dane logowania", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

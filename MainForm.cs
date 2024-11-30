using BankApp.HTTP;

namespace BankApp
{
    public partial class MainForm : Form
    {
        public string? token;

        public MainForm()
        {
            InitializeComponent();
            new LoginForm(this).ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(this.token != null)
            {
                this.TestLabel.Text = this.token;
            } else
            {
                this.TestLabel.Text = "Brak tokenu";
            }
        }
    }
}

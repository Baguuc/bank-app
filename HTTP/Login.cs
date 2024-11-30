namespace BankApp.HTTP
{
    public class LoginData
    {
        public string login { get; set; }
        public string password { get; set; }

        public LoginData(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }

    public class LoginResponse
    {
        public string? token { get; set; }
        public string? error { get; set; }

        public LoginResponse(string? token, string? error)
        {
            this.token = token;
            this.error = error;
        }
    }
}

namespace BankApp.HTTP
{
    public class AccountDetailsData
    {
        public string token { get; set; }

        public AccountDetailsData(string token)
        {
            this.token = token;
        }
    }

    public class AccountDetailsResponse
    {
        public int? accountNo { get; set; }
        public string? name { get; set; }
        public int? amount { get; set; }
        public string? error { get; set; }

        public AccountDetailsResponse(int? accountNo, string? name, int? amount, string? error)
        {
            this.accountNo = accountNo;
            this.name = name;
            this.amount = amount;
            this.error = error;
        }
    }

    public class AccountDetails
    {
        public int accountNo { get; set; }
        public string name { get; set; }
        public int amount { get; set; }

        public AccountDetails(int accountNo, string name, int amount)
        {
            this.accountNo = accountNo;
            this.name = name;
            this.amount = amount;
        }
    }
    public class WrongTokenException : Exception
    {
        public WrongTokenException() : base("Wrong token provided") { }
    }
}

namespace BankApp.HTTP
{
    public class NewTransferData
    {
        public string token { get; set; }
        public int target { get; set; }
        public int amount { get; set; }

        public NewTransferData(string token, int target, int amount)
        {
            this.token = token;
            this.target = target;
            this.amount = amount;
        }
    }

    public class NewTransferResponse
    {
        public string? error { get; set; }

        public NewTransferResponse(string? error)
        {
            this.error = error;
        }
    }
}

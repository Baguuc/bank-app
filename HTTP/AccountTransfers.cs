using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.HTTP
{
    public class AccountTransfersData
    {
        public string token { get; set; }

        public AccountTransfersData(string token)
        {
            this.token = token;
        }
    }

    public class AccountTransfersResponse
    {
        public Transfer[]? transfers { get; set; }
        public string? error { get; set; }

        public AccountTransfersResponse(Transfer[]? transfers, string? error)
        {
            this.transfers = transfers;
            this.error = error;
        }
    }

    public class Transfer
    {
        public string timestamp { get; set; }
        public string targetName { get; set; }
        public int amount { get; set; }

        public Transfer(string timestamp, string targetName, int amount)
        {
            this.timestamp = timestamp;
            this.targetName = targetName;
            this.amount = amount;
        }
    }
}

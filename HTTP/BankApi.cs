using System.Net.Http.Json;
using System.Text.Json;

namespace BankApp.HTTP
{
    public class BankApi
    {
        public static string GetBaseUrl()
        {
            return "http://localhost/bankapi";
        }

        public static string GetUrlForRoute(string route)
        {
            // usuwamy niepotrzebne znaki "/"
            // z początku i końca ścieżki
            string routeTrimmed = route
                .TrimStart('/')
                .TrimEnd('/');

            // zwracamy pełną ścieżkę
            return $"{GetBaseUrl()}/{routeTrimmed}";
        }

        public static string Login(LoginData data)
        {
            HttpClient client = new HttpClient();
            string url = GetUrlForRoute("login");
            HttpResponseMessage response =
                client.PostAsJsonAsync(url, data).Result;

            string json = response.Content.ReadAsStringAsync().Result;
            LoginResponse responseData = JsonSerializer.Deserialize<LoginResponse>(json);

            string? token = responseData.token;
            string? error = responseData.error;

            if (token != null && error == null)
            {
                return token;
            }
            else
            {
                throw new WrongCredentialsException();
            }
        }

        public static AccountDetails GetAccountDetails(AccountDetailsData data)
        {
            HttpClient client = new HttpClient();
            string url = GetUrlForRoute("account/details");
            HttpResponseMessage response =
                client.PostAsJsonAsync(url, data).Result;

            string json = response.Content.ReadAsStringAsync().Result;
            AccountDetailsResponse? responseData = JsonSerializer.Deserialize<AccountDetailsResponse>(json);

            int? accountNo = responseData.accountNo;
            string? name = responseData.name;
            int? amount = responseData.amount;
            string? error = responseData.error;

            if (accountNo != null && name != null && amount != null && error == null)
            {
                // z jakiegos powodu mimo sprawdzenia ze accountNo i amount nie sa nullem
                // nie mozna ich podac jako argumenty typu "int" zamiast "int?"
                // wiec wstawiamy podstawowa wartosc kiedy sa nullem (to i tak sie nie stanie bo juz to zostalo sprawdzone)
                return new AccountDetails(accountNo ?? 0, name, amount ?? 0);
            }
            else
            {
                throw new WrongTokenException();
            }
        }

        public static Transfer[] GetAccountTransfers(AccountTransfersData data)
        {
            HttpClient client = new HttpClient();
            string url = GetUrlForRoute("account/transfers");
            HttpResponseMessage response =
                client.PostAsJsonAsync(url, data).Result;

            string json = response.Content.ReadAsStringAsync().Result;
            AccountTransfersResponse? responseData = JsonSerializer.Deserialize<AccountTransfersResponse>(json);

            Transfer[]? transfers = responseData.transfers;
            string? error = responseData.error;

            if (transfers != null && error == null)
            {
                return transfers;
            }
            else
            {
                throw new WrongTokenException();
            }
        }

        public static void CreateTransfer(NewTransferData data)
        {
            HttpClient client = new HttpClient();
            string url = GetUrlForRoute("transfer/new");
            HttpResponseMessage response =
                client.PostAsJsonAsync(url, data).Result;

            string json = response.Content.ReadAsStringAsync().Result;
            NewTransferResponse? responseData = JsonSerializer.Deserialize<NewTransferResponse>(json);

            string? error = responseData.error;

            if (error != null)
            {
                switch (error)
                {
                    case "Invalid token":
                        throw new WrongTokenException();
                    case "Cannot create a transfer with negative amount.":
                        throw new NegativeTransferAmountException();
                    case "Your balance is too low to do this transfer.":
                        throw new BalanceTooLowException();
                    case "The target account do not exist.":
                        throw new WrongTargetAccountException();
                }
            }
        }
    }

    public class WrongCredentialsException : Exception
    {
        public WrongCredentialsException() { }
    }

    public class WrongTokenException : Exception
    {
        public WrongTokenException() { }
    }

    public class BalanceTooLowException : Exception
    {
        public BalanceTooLowException() { }
    }

    public class NegativeTransferAmountException : Exception
    {
        public NegativeTransferAmountException() { }
    }

    public class WrongTargetAccountException : Exception
    {
        public WrongTargetAccountException() { }
    }
}

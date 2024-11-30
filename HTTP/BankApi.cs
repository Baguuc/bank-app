using System.Net.Http.Json;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            } else
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
    }
}

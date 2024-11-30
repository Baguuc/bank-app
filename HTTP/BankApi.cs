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
    }
}

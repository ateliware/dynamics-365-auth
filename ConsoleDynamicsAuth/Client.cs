using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsoleDynamicsAuth
{
    public static class Client
    {
        public static string GetSystemUsers(string accessTokenType, string accessToken)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                        accessTokenType, accessToken);

                    HttpResponseMessage response = httpClient.GetAsync(
                        ClientConfiguration.Default.ActiveDirectoryResource + "/data/SystemUsers").Result;

                    return response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    string.Format("Falha ao consultar a aplicação com a exception: {0} e stack trace: {1}",
                        ex.ToString(), ex.StackTrace));

                throw new Exception("Falha ao consultar a aplicação");
            }
        }
    }
}

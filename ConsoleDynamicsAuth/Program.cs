using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;

namespace ConsoleDynamicsAuth
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthenticationResult authenticationResult = ClientAuth.GetAuthenticationInfo();

            Console.WriteLine(
                string.Format("JWT Token: {0}",
                    authenticationResult.CreateAuthorizationHeader()));

            Console.WriteLine(
                string.Format("{0}",
                    Client.GetSystemUsers(authenticationResult.AccessTokenType, authenticationResult.AccessToken)));

            Console.ReadLine();
        }
    }
}

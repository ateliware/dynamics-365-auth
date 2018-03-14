using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;

namespace ConsoleDynamicsAuth
{
    public static class ClientAuth
    {
        public static AuthenticationResult GetAuthenticationInfo()
        {
            UriBuilder uri = new UriBuilder(ClientConfiguration.Default.ActiveDirectoryTenant);
            AuthenticationContext authenticationContext = new AuthenticationContext(uri.ToString());
            AuthenticationResult authenticationResult;

            try
            {
                var creadential = new ClientCredential(
                    ClientConfiguration.Default.ActiveDirectoryClientAppId,
                    ClientConfiguration.Default.ActiveDirectoryClientAppSecret);

                authenticationResult = authenticationContext.AcquireTokenAsync(
                    ClientConfiguration.Default.ActiveDirectoryResource, creadential).Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    string.Format("Falha ao autenticar com o AAD por aplicação com a exception: {0} e stack trace: {1}",
                        ex.ToString(), ex.StackTrace));

                throw new Exception("Falha ao autenticar com o AAD por aplicação");
            }

            return authenticationResult;
        }
    }
}

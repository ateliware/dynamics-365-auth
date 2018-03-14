using System;

namespace ConsoleDynamicsAuth
{
    public partial class ClientConfiguration
    {
        public static ClientConfiguration Default { get { return ClientConfiguration.OneBox; } }

        public static ClientConfiguration OneBox = new ClientConfiguration()
        {
            ActiveDirectoryResource = "https://usnconeboxax1aos.cloud.onebox.dynamics.com",
            ActiveDirectoryTenant = "https://login.windows.net/ateliware.com.br",
            ActiveDirectoryClientAppId = "5ead9c17-8d5d-4693-b852-e4592d920869",
            ActiveDirectoryClientAppSecret = "2gTSCW3nAqexzcRaRaaMpj+XlvIoMBurDBnHU1IMMYk=",
        };

        public string ActiveDirectoryResource { get; set; }
        public String ActiveDirectoryTenant { get; set; }
        public String ActiveDirectoryClientAppId { get; set; }
        public string ActiveDirectoryClientAppSecret { get; set; }
    }
}

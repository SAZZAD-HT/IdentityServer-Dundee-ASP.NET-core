using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace IdentityServer
{
    public  static class SD
    {
      public const string AdminEndUser = "Admin";
      public const string CustomerEndUser = "Customer";

        //public static IEnumerable<IdentityResource> GetIdentityResources()
        //{
        //   return
        //    new List<IdentityResource>
        //    {
        //      new IdentityResources.OpenId(),
        //      new IdentityResources.Email(),
        //      new IdentityResources.Profile()
        //    };
        //}
        public static IEnumerable<IdentityResource> IdentityResources =>
         new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Email(),
            new IdentityResources.Profile()
        };
        public static IEnumerable<ApiScope> GetApiScopes =>
         new List<ApiScope>
             {      new ApiScope(name: "all",   displayName: "Identity"),
                    new ApiScope(name: "read",   displayName: "Read your data."),
                    new ApiScope(name: "write",  displayName: "Write your data."),
                    new ApiScope(name: "delete", displayName: "Delete your data.")
             };


        public static IEnumerable<Client> Clients =>
           new List<Client>
           {
              new Client
              {
                 ClientId = "service.client",
                 ClientSecrets = { new Secret("secret".Sha256()) },
                 AllowedGrantTypes = GrantTypes.ClientCredentials,
                 AllowedScopes = { "api1", "api2.read_only" }
              },
               new Client
              {
                 ClientId = "User1",
                 ClientSecrets = { new Secret("secret".Sha256()) },
                 AllowedGrantTypes = GrantTypes.Code,
                 AllowedScopes = { "all",IdentityServerConstants.StandardScopes.OpenId,
                   IdentityServerConstants.StandardScopes.Profile,
                   IdentityServerConstants.StandardScopes.Email},
                 RedirectUris = { "https://localhost:7002/signin-oidc" },
                 PostLogoutRedirectUris = { "https://localhost:7002/signout-callback-oidc" },
               }
            };



    }
}

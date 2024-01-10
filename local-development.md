# Local Development

Relecloud developers use Visual Studio to develop and they integrate directly with Azure resources for local dev. The team chooses this workflow to so they can develop as their code would behave when deployed to Azure allowing them to catch issues like serialization exceptions.


> **WARNING**
>
> Local development is only supported when the Azure resources are not network isolated.
> If you are using network isolation you will only be able to access the Azure resources from the jump host.
>

To connect to the Azure resources the dev team uses connection strings from Key Vault and App Configuration Service. Devs use the following script to retrieve data and store it as [User Secrets](https://learn.microsoft.com/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows) on their workstation.

Using the `secrets.json` file helps the team keep their credentials secure. The file is stored outside of the source control directory so the data is never accidentally checked-in. And the devs don't share credentials over email or other ways that could compromise their security.

Managing secrets from Key Vault and App Configuration ensures that only authorized team members can access the data and also centralizes the administration of these secrets so they can be easily changed.

New team members should setup their environment by following these steps.

1. Open the Visual Studio solution `./src/Relecloud.sln`
1. Setup the **Relecloud.Web.CallCenter** project User Secrets
    1. Right-click on the **Relecloud.Web.CallCenter** project
    1. From the context menu choose **Manage User Secrets**
    1. Validate that the `secrets.json` file is configured with `App:AppConfig:Uri` or set it based on the AZD environment variable.

1. Setup the **Relecloud.Web.CallCenter.Api** project User Secrets
    1. Right-click on the **Relecloud.Web.CallCenter.Api** project
    1. From the context menu choose **Manage User Secrets**
    1. Validate that the `secrets.json` file is configured with `App:AppConfig:Uri` or set it based on the AZD environment variable.

1. Right-click the **Relecloud** solution and pick **Set Startup Projects...**
1. Choose **Multiple startup projects**
1. Change the dropdowns for *Relecloud.Web.CallCenter* and *Relecloud.Web.CallCenter.Api* to the action of **Start**.
1. Click **Ok** to close the popup

1. When connecting to Azure SQL database you'll connect with your Azure AD account.
Run the following command to give your Azure AD account permission to access the database.

    <table>
    <tr>
    <td>PowerShell</td>
    <td>

    ```ps1
    pwsh -c "Set-ExecutionPolicy Bypass Process; .\infra\localDevScripts\makeSqlUserAccount.ps1 -g '$myEnvironmentName-rg'"
    ```

    </td>
    </tr>
    <tr>
    <td>Bash</td>
    <td>
            
    ```bash
    ./infra/localDevScripts/makeSqlUserAccount.sh -g "$myEnvironmentName-rg"
    ```

    </td>
    </tr>
    </table>

1. Press F5 to start debugging the website

> These steps grant access to SQL server in the primary resource group.
> You can use the same commands if you want to test with the secondary resource
> group by changing the ResourceGroup parameter "-g" to "$myEnvironmentName-secondary-rg"
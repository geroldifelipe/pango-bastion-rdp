using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pango.Application.AzureCliData;
using Pango.Application.Exceptions;
using Pango.Application.Extensions;
using Pango.Application.PlatformShell;
using System.Diagnostics;
using System.Security.Principal;

namespace Pango.Application
{
    public static class AzureCli
    {
        private static Process RunAzureCLICommand(string azCommand, bool createWindow = false, bool waitForExit = true)
        {
            var platformShellOpt = PlatformShellOptions.GetOptions();

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = platformShellOpt.Shell,
                    Arguments = $"{platformShellOpt.ShellCommandParser} \"az {azCommand}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = !createWindow
                }
            };

            process.Start();
            if(waitForExit)
                process.WaitForExit();

            return process;
        }

        public static string GetAzureCLIInformation()
        {
            var commandResult = RunAzureCLICommand("--version");
            return commandResult.StandardOutput.ReadToEnd();
        }

        public static void CheckAzureCLI()
        {
            var commandResult = RunAzureCLICommand("--version");
            if (commandResult.Failed())
                throw new AzureCliNotFoundException("The Azure CLI was not found");
        }

        public static AzureCliLoginInformation GetLoginInformation()
        {
            var commandResult = RunAzureCLICommand("account show");
            if (commandResult.Failed())
                throw new AzureCliNotLoggedInException("User not logged in");

            var loginInfo = JsonConvert.DeserializeObject<AzureCliLoginInformation>(commandResult.StandardOutput.ReadToEnd());
            return loginInfo!;
        }

        public static void RequestLogin()
        {
            var commandResult = RunAzureCLICommand("login --use-device-code", createWindow: true);
            if (commandResult.Failed())
                throw new AzureCliLoginFailedException("Login failed");
        }

        public static void Logout()
        {
            var commandResult = RunAzureCLICommand("logout", createWindow: false);
            if (commandResult.Failed())
                throw new AzureCliLoginFailedException("Logout failed");
        }

        public static IEnumerable<AzureCliAccountSubscription> GetSubscriptions()
        {
            var commandResult = RunAzureCLICommand("account subscription list");
            if (commandResult.Failed())
                throw new AzureCliNotLoggedInException("User not logged in");

            var subscriptions = JsonConvert.DeserializeObject<List<AzureCliAccountSubscription>>(commandResult.StandardOutput.ReadToEnd());
            return subscriptions!;
        }

        public static IEnumerable<AzureCliResourceGroup> GetResourceGroupsList(string subscriptionId)
        {
            var commandResult = RunAzureCLICommand($"group list --subscription {subscriptionId}");
            if (commandResult.Failed())
                throw new AzureCliNotLoggedInException("User not logged in");

            var groups = JsonConvert.DeserializeObject<List<AzureCliResourceGroup>>(commandResult.StandardOutput.ReadToEnd());
            return groups!;
        }

        public static void SelectSubscription(string selectedSubscriptionId)
        {
            var commandResult = RunAzureCLICommand($"account set --subscription {selectedSubscriptionId}");
            if (commandResult.Failed())
                throw new AzureCliLoginFailedException("Login failed");
        }

        public static IEnumerable<AzureCliVirtualMachine> GetResourceGroupVirtualMachines(string selectedGroupName)
        {
            var commandResult = RunAzureCLICommand($"vm list --resource-group {selectedGroupName}");
            if (commandResult.Failed())
                throw new AzureCliNotLoggedInException("User not logged in");

            var vms = JsonConvert.DeserializeObject<List<AzureCliVirtualMachine>>(commandResult.StandardOutput.ReadToEnd());
            return vms!;
        }

        public static IEnumerable<AzureCliBastion> GetResourceGroupBastions(string selectedGroupName)
        {
            var commandResult = RunAzureCLICommand($"network bastion list --resource-group {selectedGroupName}");
            if (commandResult.Failed())
                throw new AzureCliNotLoggedInException("User not logged in");

            var bastions = JsonConvert.DeserializeObject<List<AzureCliBastion>>(commandResult.StandardOutput.ReadToEnd());
            return bastions!;
        }

        public static void ConnectBastionRdp(string selectedResourceGroup, string selectedVirtualMachine, string selectedBastion)
        {
            RunAzureCLICommand($"network bastion rdp --name {selectedBastion} --resource-group {selectedResourceGroup} --target-resource-id {selectedVirtualMachine} --disable-gateway",
                waitForExit: false);
        }
    }
}

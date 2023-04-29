using Pango.Application;
using Pango.Application.AzureCliData;
using Pango.Application.Exceptions;

namespace Pango.DesktopApp;

public partial class MainForm : Form
{
    public bool UserIsLoggedIn = false;
    public string SelectedSubscriptionId = string.Empty;

    public MainForm()
    {
        CheckAzureCliInstalation();
        InitializeComponent();

        LoadAzureCliLoginInformation();
        if (UserIsLoggedIn)
        {
            LoadSubscriptionsList();
        }
    }

    private void LoadSubscriptionsList()
    {
        IEnumerable<AzureCliAccountSubscription> subscriptions = AzureCli.GetSubscriptions();
        var dataSource = subscriptions
            .Select(x => new { Id = x.SubscriptionId, Text = x.DisplayName })
            .ToList();

        dataSource.Add(new { Id = "", Text = "Select..." });
        cbSubscription.ValueMember = "Id";
        cbSubscription.DisplayMember = "Text";
        cbSubscription.DataSource = dataSource.OrderBy(x => x.Id).ToList();
    }

    public void ShowLoginInformation(AzureCliLoginInformation loginInfo)
    {
        loginToolStripMenuItem.Text = loginInfo.User.Name;
        loginToolStripMenuItem.Click -= null;
        logoutToolStripMenuItem.Visible = true;
        UserIsLoggedIn = true;
    }

    private void LoadAzureCliLoginInformation()
    {
        try
        {
            AzureCliLoginInformation loginInfo = AzureCli.GetLoginInformation();
            ShowLoginInformation(loginInfo);
        }
        catch (AzureCliNotLoggedInException)
        {
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += LoginToolStripMenuItem_Click_Login;
            logoutToolStripMenuItem.Visible = false;
            UserIsLoggedIn = false;
        }
    }

    private void LoginToolStripMenuItem_Click_Login(object? sender, EventArgs e)
    {
        try
        {
            AzureCli.RequestLogin();
            AzureCliLoginInformation loginInfo = AzureCli.GetLoginInformation();
            ShowLoginInformation(loginInfo);

        }
        catch (AzureCliLoginFailedException)
        {
            MessageBox.Show("The login on Azure CLI has failed, try again.", "Login failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void CheckAzureCliInstalation()
    {
        try
        {
            AzureCli.CheckAzureCLI();
        }
        catch (AzureCliNotFoundException e)
        {
            string msAzureCliInstallationLink = "https://learn.microsoft.com/pt-br/cli/azure/install-azure-cli-windows";
            string errorMessage = string.Format($"{e.Message}, please follow the instructions available at {msAzureCliInstallationLink}");
            MessageBox.Show(errorMessage, "Azure CLI not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Environment.Exit(1);
        }
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var aboutBox = new AboutBox();
        aboutBox.ShowDialog();
    }

    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AzureCli.Logout();
        loginToolStripMenuItem.Text = "Login";
        loginToolStripMenuItem.Click += LoginToolStripMenuItem_Click_Login;
        logoutToolStripMenuItem.Visible = false;
        UserIsLoggedIn = false;
    }

    private void cbSubscription_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectedSubscriptionId = cbSubscription.SelectedValue.ToString()!;
        if (!string.IsNullOrEmpty(SelectedSubscriptionId))
            AzureCli.SelectSubscription(SelectedSubscriptionId);

        ClearSubscriptionDependantValues();
        LoadResourceGroupsList(SelectedSubscriptionId);
    }

    private void LoadResourceGroupsList(string subscriptionId)
    {
        if (!string.IsNullOrEmpty(subscriptionId))
        {
            var groups = AzureCli.GetResourceGroupsList(SelectedSubscriptionId);
            var dataSource = groups
                .Select(x => new { Id = x.Name, Text = x.Name })
                .ToList();

            dataSource.Add(new { Id = "", Text = "Select..." });
            cbResourceGroup.ValueMember = "Id";
            cbResourceGroup.DisplayMember = "Text";
            cbResourceGroup.DataSource = dataSource.OrderBy(x => x.Id).ToList();
        }
    }

    private void ClearSubscriptionDependantValues()
    {
        ClearResourceGroupList();
    }

    private void ClearResourceGroupList()
    {
        cbResourceGroup.DataSource = null;
        cbResourceGroup.Items.Clear();
    }

    private void cbResourceGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedGroup = cbResourceGroup.SelectedValue.ToString()!;

        ClearResourceGroupDependantValues();
        LoadVirtualMachineList(selectedGroup);
        LoadBastionList(selectedGroup);
    }

    private void ClearResourceGroupDependantValues()
    {
        ClearVirtualMachineList();
        ClearBastionList();
    }

    private void ClearVirtualMachineList()
    {
        cbVirtualMachine.DataSource = null;
        cbVirtualMachine.Items.Clear();
    }

    private void ClearBastionList()
    {
        cbBastion.DataSource = null;
        cbBastion.Items.Clear();
    }

    private void LoadBastionList(string selectedGroupName)
    {
        if (!string.IsNullOrEmpty(selectedGroupName))
        {
            var bastions = AzureCli.GetResourceGroupBastions(selectedGroupName);
            var dataSource = bastions
                .Select(x => new { Id = x.Name, Text = x.Name })
                .ToList();

            dataSource.Add(new { Id = "", Text = "Select..." });
            cbBastion.ValueMember = "Id";
            cbBastion.DisplayMember = "Text";
            cbBastion.DataSource = dataSource.OrderBy(x => x.Id).ToList();
        }
    }

    private void LoadVirtualMachineList(string selectedGroupName)
    {
        if (!string.IsNullOrEmpty(selectedGroupName))
        {
            var vms = AzureCli.GetResourceGroupVirtualMachines(selectedGroupName);
            var dataSource = vms
                .Select(x => new { Id = x.Id, Text = x.Name })
                .ToList();

            dataSource.Add(new { Id = "", Text = "Select..." });
            cbVirtualMachine.ValueMember = "Id";
            cbVirtualMachine.DisplayMember = "Text";
            cbVirtualMachine.DataSource = dataSource.OrderBy(x => x.Id).ToList();
        }
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
        string? selectedResourceGroup = cbResourceGroup.SelectedValue?.ToString();
        string? selectedVirtualMachine = cbVirtualMachine.SelectedValue?.ToString();
        string? selectedBastion = cbBastion.SelectedValue?.ToString();

        if (!string.IsNullOrEmpty(selectedResourceGroup)
            && !string.IsNullOrEmpty(selectedVirtualMachine)
            && !string.IsNullOrEmpty(selectedBastion))
        {
            AzureCli.ConnectBastionRdp(selectedResourceGroup, selectedVirtualMachine, selectedBastion);
        }
        else
        {
            MessageBox.Show("Invalid connection parameters", "Connection failed", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }
    }
}
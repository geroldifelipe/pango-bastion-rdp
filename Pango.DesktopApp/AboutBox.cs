using Pango.Application;

namespace Pango.DesktopApp;

public partial class AboutBox : Form
{
    public AboutBox()
    {
        InitializeComponent();
        LoadAzureCliInformation();
    }

    public void LoadAzureCliInformation()
    {
        string information = AzureCli.GetAzureCLIInformation();
        var informationLines = information.Split("\r\n").ToList();
        informationLines.RemoveRange(13, 6);
        tbAzureCliInformation.Lines = informationLines.ToArray();
    }
}

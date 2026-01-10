using System.Windows;
using Velopack;

namespace MarkItDownX;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private const string UpdateFeedUrl = "https://github.com/1llum1n4t1s/MarkItDownX/releases/latest/download";

    protected override async void OnStartup(StartupEventArgs e)
    {
        var updateManager = new UpdateManager(UpdateFeedUrl);
        var updateInfo = await updateManager.CheckForUpdatesAsync();
        if (updateInfo is not null)
        {
            await updateManager.DownloadUpdatesAsync(updateInfo);
            updateManager.ApplyUpdatesAndRestart();
            return;
        }

        base.OnStartup(e);
    }
}

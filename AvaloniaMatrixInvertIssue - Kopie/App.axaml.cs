using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using AvaloniaMatrixInvertIssue.ViewModels;
using AvaloniaMatrixInvertIssue.Views;
using Material.Styles.Themes;

namespace AvaloniaMatrixInvertIssue;
public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Line below is needed to remove Avalonia data validation.
            // Without this line you will get duplicate validations from both Avalonia and CT
            BindingPlugins.DataValidators.RemoveAt(0);
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
        }

        base.OnFrameworkInitializationCompleted();

        SetLightTheme();
        //DialogHostAvalonia.DialogHostStyles
    }

    private static Theme LightTheme { get; } = Theme.Create(
        Theme.Light,
        Color.Parse("#343838"),
        Color.Parse("#F9A825")
    );

    private static Theme DarkTheme { get; } = Theme.Create(
        Theme.Dark,
        Color.Parse("#E8E8E8"),
        Color.Parse("#F9A825")
    );

    public static void SetLightTheme()
    {
        var theme = App.Current!.LocateMaterialTheme<MaterialThemeBase>();
        theme.CurrentTheme = LightTheme;

        Current!.Resources["SuccessBrush"] = new SolidColorBrush(Colors.DarkGreen);
        Current!.Resources["CanceledBrush"] = new SolidColorBrush(Colors.DarkOrange);
        Current!.Resources["FailedBrush"] = new SolidColorBrush(Colors.DarkRed);
    }

    public static void SetDarkTheme()
    {
        var theme = App.Current!.LocateMaterialTheme<MaterialThemeBase>();
        theme.CurrentTheme = DarkTheme;

        Current!.Resources["SuccessBrush"] = new SolidColorBrush(Colors.LightGreen);
        Current!.Resources["CanceledBrush"] = new SolidColorBrush(Colors.Orange);
        Current!.Resources["FailedBrush"] = new SolidColorBrush(Colors.OrangeRed);
    }
}
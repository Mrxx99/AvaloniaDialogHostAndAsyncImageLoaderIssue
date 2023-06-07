using CommunityToolkit.Mvvm.ComponentModel;

namespace Sandbox.ViewModels;
public partial class ItemViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _title;

    [ObservableProperty]
    private string _url;
}

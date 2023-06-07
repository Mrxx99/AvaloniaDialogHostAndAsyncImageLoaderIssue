using CommunityToolkit.Mvvm.ComponentModel;

namespace preview3.ViewModels;
public partial class ItemViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _title;

    [ObservableProperty]
    private string _url;
}

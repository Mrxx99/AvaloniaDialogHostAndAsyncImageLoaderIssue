using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaMatrixInvertIssue.ViewModels;
public partial class VideoViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _title;

    [ObservableProperty]
    private string _url;
}

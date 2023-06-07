using System;
using System.Collections.ObjectModel;

namespace AvaloniaMatrixInvertIssue.ViewModels;
public class DialogViewModel : ViewModelBase
{
    public ObservableCollection<VideoViewModel> AvailableVideos { get; } = new()
    {
        new VideoViewModel() { Title = "Video1", Url = "https://img.youtube.com/vi/YQHsXMglC9A/default.jpg" },
        new VideoViewModel() { Title = "Video2", Url = "https://img.youtube.com/vi/mHONNcZbwDY/default.jpg" },
        new VideoViewModel() { Title = "Video3", Url = "https://img.youtube.com/vi/kK42LZqO0wA/default.jpg" },
        new VideoViewModel() { Title = "Video4", Url = "https://img.youtube.com/vi/bnVUHWCynig/default.jpg" },
        new VideoViewModel() { Title = "Video5", Url = "https://img.youtube.com/vi/be12BC5pQLE/default.jpg" },
        new VideoViewModel() { Title = "Video6", Url = "https://img.youtube.com/vi/aPd9exmH17o/default.jpg" },
        new VideoViewModel() { Title = "Video7", Url = "https://img.youtube.com/vi/Axx9IMdL4jc/default.jpg" },
        new VideoViewModel() { Title = "Video8", Url = "https://img.youtube.com/vi/jNm_wrWquPs/default.jpg" },
        new VideoViewModel() { Title = "Video9", Url = "https://img.youtube.com/vi/VS34wX-BzUY/default.jpg" },
        new VideoViewModel() { Title = "Video10", Url = "https://img.youtube.com/vi/fazMSCZg-mw/default.jpg" },
        new VideoViewModel() { Title = "Video11", Url = "https://img.youtube.com/vi/k5t0RrijpHg/default.jpg" },
        new VideoViewModel() { Title = "Video12", Url = "https://img.youtube.com/vi/uixkkqOQoD0/default.jpg" },
        new VideoViewModel() { Title = "Video13", Url = "https://img.youtube.com/vi/KZS8d0zXaUU/default.jpg" },
        new VideoViewModel() { Title = "Video14", Url = "https://img.youtube.com/vi/eldeaIAv_wE/default.jpg" },
        new VideoViewModel() { Title = "Video15", Url = "https://img.youtube.com/vi/Zox2qo-wzb0/default.jpg" },
        new VideoViewModel() { Title = "Video16", Url = "https://img.youtube.com/vi/tVlcKp3bWH8/default.jpg" },
        new VideoViewModel() { Title = "Video17", Url = "https://img.youtube.com/vi/jK5FOyMhDOY/default.jpg" },
        new VideoViewModel() { Title = "Video18", Url = "https://img.youtube.com/vi/fN1Cyr0ZK9M/default.jpg" },
        new VideoViewModel() { Title = "Video19", Url = "https://img.youtube.com/vi/LtQUJMBH8uE/default.jpg" },
        new VideoViewModel() { Title = "Video20", Url = "https://img.youtube.com/vi/fn3ldZ5xSZI/default.jpg" },
    };

    public object? DialogResult { get; private set; }

    public event EventHandler? Closed;

    public void Close(object? dialogResult)
    {
        DialogResult = dialogResult;
        Closed?.Invoke(this, EventArgs.Empty);
    }
}

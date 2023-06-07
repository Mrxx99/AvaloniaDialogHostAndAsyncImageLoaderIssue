using System;
using System.Collections.ObjectModel;

namespace AvaloniaMatrixInvertIssue.ViewModels;
public class DialogViewModel : ViewModelBase
{
    public ObservableCollection<ItemViewModel> AvailableItems { get; } = new()
    {
        new ItemViewModel() { Title = "Item01", Url = "https://dummyimage.com/60x40/1c8211/fff&text=1" },
        new ItemViewModel() { Title = "Item02", Url = "https://dummyimage.com/60x40/1c8211/fff&text=2" },
        new ItemViewModel() { Title = "Item03", Url = "https://dummyimage.com/60x40/1c8211/fff&text=3" },
        //new ItemViewModel() { Title = "Item04", Url = "https://dummyimage.com/60x40/1c8211/fff&text=4" },
        //new ItemViewModel() { Title = "Item05", Url = "https://dummyimage.com/60x40/1c8211/fff&text=5" },
        //new ItemViewModel() { Title = "Item06", Url = "https://dummyimage.com/60x40/1c8211/fff&text=6" },
        //new ItemViewModel() { Title = "Item07", Url = "https://dummyimage.com/60x40/1c8211/fff&text=7" },
        //new ItemViewModel() { Title = "Item08", Url = "https://dummyimage.com/60x40/1c8211/fff&text=8" },
        //new ItemViewModel() { Title = "Item09", Url = "https://dummyimage.com/60x40/1c8211/fff&text=9" },
        //new ItemViewModel() { Title = "Item10", Url = "https://dummyimage.com/60x40/1c8211/fff&text=10" },
        //new ItemViewModel() { Title = "Item11", Url = "https://dummyimage.com/60x40/1c8211/fff&text=11" },
        //new ItemViewModel() { Title = "Item12", Url = "https://dummyimage.com/60x40/1c8211/fff&text=12" },
        //new ItemViewModel() { Title = "Item13", Url = "https://dummyimage.com/60x40/1c8211/fff&text=13" },
        //new ItemViewModel() { Title = "Item14", Url = "https://dummyimage.com/60x40/1c8211/fff&text=14" },
        //new ItemViewModel() { Title = "Item15", Url = "https://dummyimage.com/60x40/1c8211/fff&text=15" },
        //new ItemViewModel() { Title = "Item16", Url = "https://dummyimage.com/60x40/1c8211/fff&text=16" },
        //new ItemViewModel() { Title = "Item17", Url = "https://dummyimage.com/60x40/1c8211/fff&text=17" },
        //new ItemViewModel() { Title = "Item18", Url = "https://dummyimage.com/60x40/1c8211/fff&text=18" },
        //new ItemViewModel() { Title = "Item19", Url = "https://dummyimage.com/60x40/1c8211/fff&text=19" },
        //new ItemViewModel() { Title = "Item20", Url = "https://dummyimage.com/60x40/1c8211/fff&text=20" },
    };

    public object? DialogResult { get; private set; }

    public event EventHandler? Closed;

    public void Close(object? dialogResult)
    {
        DialogResult = dialogResult;
        Closed?.Invoke(this, EventArgs.Empty);
    }
}

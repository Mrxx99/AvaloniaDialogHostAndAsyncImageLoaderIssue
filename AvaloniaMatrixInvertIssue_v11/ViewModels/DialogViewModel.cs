using System;

namespace AvaloniaMatrixInvertIssue.ViewModels;
public class DialogViewModel : ViewModelBase
{
    public object? DialogResult { get; private set; }

    public event EventHandler? Closed;

    public void Close(object? dialogResult)
    {
        DialogResult = dialogResult;
        Closed?.Invoke(this, EventArgs.Empty);
    }
}

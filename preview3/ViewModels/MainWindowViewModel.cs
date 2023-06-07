using System;
using preview3.Views;
using DialogHostAvalonia;

namespace preview3.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public async void ShowDialog()
    {
        var dialogView = new DialogView();
        var dialogViewModel = new DialogViewModel();
        dialogView.DataContext = dialogViewModel;
        void OnDialogOpened(object? openSender, DialogOpenedEventArgs openArgs)
        {
            void OnScreenClosed(object? closeSender, EventArgs closeArgs)
            {
                openArgs.Session.Close();
                dialogViewModel.Closed -= OnScreenClosed;
            }
            dialogViewModel.Closed += OnScreenClosed;
        }

        await DialogHost.Show(dialogView, OnDialogOpened);
    }
}
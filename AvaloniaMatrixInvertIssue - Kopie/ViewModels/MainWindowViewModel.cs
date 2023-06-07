using System;
using System.Threading.Tasks;
using Avalonia.Metadata;
using AvaloniaMatrixInvertIssue.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using DialogHostAvalonia;

namespace AvaloniaMatrixInvertIssue.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsProgressIndeterminate))]
    private bool _isBusy;

    [ObservableProperty]
    private string? _query;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsProgressIndeterminate))]
    private double _progress;

    public bool IsProgressIndeterminate => IsBusy && Progress is <= 0 or >= 1;

    [DependsOn(nameof(IsBusy))]
    [DependsOn(nameof(Query))]
    public bool CanProcessQuery(object _) => !IsBusy && !string.IsNullOrWhiteSpace(Query);

    public async void ProcessQuery()
    {
        if (string.IsNullOrWhiteSpace(Query))
            return;

        IsBusy = true;
        Progress = -1;
        await Task.Delay(2_000);

        for (int i = 0; i < 101; i++)
        {
            await Task.Delay(20);
            Progress = i / 100d;
        }


        Progress = -1;
        await Task.Delay(2_000);

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

        IsBusy = false;
        Query = null;
    }
}
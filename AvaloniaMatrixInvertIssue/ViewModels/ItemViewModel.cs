﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaMatrixInvertIssue.ViewModels;
public partial class ItemViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _title;

    [ObservableProperty]
    private string _url;
}

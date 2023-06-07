using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace AvaloniaMatrixInvertIssue.Views;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        QueryTextBox.AddHandler(InputElement.KeyDownEvent, OnQueryTextBoxKeyDown, RoutingStrategies.Tunnel);
        ProcessQueryButton.Click += ProcessQueryButton_Click;
    }

    private void ProcessQueryButton_Click(object? sender, RoutedEventArgs e)
    {

    }

    private void OnQueryTextBoxKeyDown(object? sender, KeyEventArgs e)
    {
        // Disable new lines when pressing enter without shift
        if (e.Key == Key.Enter && e.KeyModifiers != KeyModifiers.Shift)
        {
            e.Handled = true;

            // We handle the event here so we have to directly "press" the default button
            //ProcessQueryButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent, ProcessQueryButton));
            ProcessQueryButton.Command?.Execute(ProcessQueryButton.CommandParameter);
            //this.RaiseEvent(new PointerPressedEventArgs(KeyDownEvent, this) { })
        }
    }

    private void QueryTextBox_OnPreviewKeyDown(object sender, KeyEventArgs e)
    {
        // Disable new lines when pressing enter without shift
        if (e.Key == Key.Enter && e.KeyModifiers != KeyModifiers.Shift)
        {
            e.Handled = true;

            // We handle the event here so we have to directly "press" the default button
            //AccessKeyManager.ProcessKey(null, "\x000D", false); // TODO
        }
    }
}
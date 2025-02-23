using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Avalonia_.NET_MVVM_App.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        TextBlockName.Text = "Clicked";
    }
}
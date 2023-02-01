using EventAggregatorExample.ViewModels;
using System.Windows;

namespace EventAggregatorExample;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        ViewModel = new MainViewModel();

        InitializeComponent();
    }

    public MainViewModel? ViewModel
    {
        get => DataContext as MainViewModel;
        set => DataContext = value;
    }
}

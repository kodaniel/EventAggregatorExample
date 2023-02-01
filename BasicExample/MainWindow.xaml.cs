using BasicExample.ViewModels;
using System.Windows;

namespace BasicExample;

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

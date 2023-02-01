namespace BasicExample.ViewModels;

public class PageBViewModel : BaseViewModel
{
    private readonly MainViewModel _mainViewModel;

    public PageBViewModel(MainViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
    }

    public string? Name { get; private set; }

    public void OnPersonNameChanged(string? oldName, string? newName)
    {
        Name = $"Hello, {newName}!";
        OnPropertyChanged(nameof(Name));
    }
}

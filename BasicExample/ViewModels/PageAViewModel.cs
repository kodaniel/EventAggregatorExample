namespace BasicExample.ViewModels;

public class PageAViewModel : BaseViewModel
{
    private readonly MainViewModel _mainViewmodel;

	public PageAViewModel(MainViewModel mainViewModel)
	{
        _mainViewmodel = mainViewModel;
        //FirstName = "Joe";
    }

    private string? _fistName;
    public string? FirstName
    {
        get => _fistName;
        set
        {
            if (value != _fistName)
            {
                var oldValue = value;
                _fistName = value;

                _mainViewmodel.PageBViewModel.OnPersonNameChanged(oldValue, value);
                _mainViewmodel.ServiceA.OnNameChanged();
                _mainViewmodel.ServiceB.OnNameChanged();
                _mainViewmodel.ServiceC.OnNameChanged();

                OnPropertyChanged(nameof(FirstName));
            }
        }
    }
}

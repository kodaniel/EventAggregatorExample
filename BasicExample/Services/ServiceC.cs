using BasicExample.ViewModels;
using System.Diagnostics;

namespace BasicExample.Services;

public class ServiceC
{
    private readonly MainViewModel _mainViewModel;

    public ServiceC(MainViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
    }

    public void OnNameChanged()
    {
        Debug.WriteLine("Service C");
    }
}

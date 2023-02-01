using BasicExample.ViewModels;
using System.Diagnostics;

namespace BasicExample.Services;

public class ServiceB
{
    private readonly MainViewModel _mainViewModel;

    public ServiceB(MainViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
    }

    public void OnNameChanged()
    {
        Debug.WriteLine("Service B");
    }
}

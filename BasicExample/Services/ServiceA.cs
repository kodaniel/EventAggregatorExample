using BasicExample.ViewModels;
using System.Diagnostics;

namespace BasicExample.Services;

public class ServiceA
{
    private readonly MainViewModel _mainViewModel;

    public ServiceA(MainViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
    }

    public void OnNameChanged()
    {
        Debug.WriteLine("Service A");
    }
}

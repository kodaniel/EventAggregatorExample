using EventAggregatorExample.Services;

namespace EventAggregatorExample.ViewModels;

public class MainViewModel : BaseViewModel
{
	public MainViewModel()
	{
		PageAViewModel = new PageAViewModel();
        PageBViewModel = new PageBViewModel();

        ServiceA = new ServiceA();
        ServiceB = new ServiceB();
        ServiceC = new ServiceC();
    }

	public PageAViewModel PageAViewModel { get; }

    public PageBViewModel PageBViewModel { get; }

    public ServiceA ServiceA { get; }
    public ServiceB ServiceB { get; }
    public ServiceC ServiceC { get; }
}

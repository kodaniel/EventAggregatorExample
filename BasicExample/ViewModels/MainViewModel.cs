using BasicExample.Services;

namespace BasicExample.ViewModels;

public class MainViewModel : BaseViewModel
{
	public MainViewModel()
	{
		PageAViewModel = new PageAViewModel(this);
        PageBViewModel = new PageBViewModel(this);

        ServiceA = new ServiceA(this);
        ServiceB = new ServiceB(this);
        ServiceC = new ServiceC(this);
    }

	public PageAViewModel PageAViewModel { get; }

    public PageBViewModel PageBViewModel { get; }

	public ServiceA ServiceA { get; }
    public ServiceB ServiceB { get; }
    public ServiceC ServiceC { get; }
}

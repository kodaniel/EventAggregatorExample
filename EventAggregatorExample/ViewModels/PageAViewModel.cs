using EventAggregatorExample.Events;

namespace EventAggregatorExample.ViewModels;

public class PageAViewModel : BaseViewModel
{
	public PageAViewModel()
	{
        FirstName = "Joe";
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

                Messenger.Publish(new PersonNameChanged(oldValue, value));

                OnPropertyChanged(nameof(FirstName));
            }
        }
    }
}

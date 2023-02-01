using EventAggregatorExample.Contracts;
using EventAggregatorExample.Events;

namespace EventAggregatorExample.ViewModels;

public class PageBViewModel : BaseViewModel
{
    public PageBViewModel()
    {
        Messenger.Subscribe<PersonNameChanged>(OnPersonNameChanged, ThreadOptions.UiThread);
    }

    public string? Name { get; private set; }

    private void OnPersonNameChanged(PersonNameChanged args)
    {
        Name = $"Hello, {args.NewValue}!";
        OnPropertyChanged(nameof(Name));
    }
}

using EventAggregatorExample.Events;
using System.Diagnostics;

namespace EventAggregatorExample.Services;

public class ServiceB
{
    public ServiceB()
    {
        CoreServices.Messenger.Subscribe<PersonNameChanged>(OnNameChanged);
    }

    private void OnNameChanged(PersonNameChanged args)
    {
        Debug.WriteLine("Service B");
    }
}

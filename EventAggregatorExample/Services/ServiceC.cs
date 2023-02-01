using EventAggregatorExample.Events;
using System.Diagnostics;

namespace EventAggregatorExample.Services;

public class ServiceC
{
    public ServiceC()
    {
        CoreServices.Messenger.Subscribe<PersonNameChanged>(OnNameChanged);
    }

    private void OnNameChanged(PersonNameChanged args)
    {
        Debug.WriteLine("Service C");
    }
}

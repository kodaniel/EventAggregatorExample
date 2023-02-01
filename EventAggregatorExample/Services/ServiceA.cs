using EventAggregatorExample.Events;
using System.Diagnostics;

namespace EventAggregatorExample.Services;

public class ServiceA
{
    public ServiceA()
    {
        CoreServices.Messenger.Subscribe<PersonNameChanged>(OnNameChanged);
    }

    private void OnNameChanged(PersonNameChanged args)
    {
        Debug.WriteLine("Service A");
    }
}

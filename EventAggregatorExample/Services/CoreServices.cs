using EventAggregatorExample.Contracts;
using System;

namespace EventAggregatorExample.Services;

public static class CoreServices
{
    private static Lazy<IMessenger> _messenger = new Lazy<IMessenger>(() => new Messenger());

    public static IMessenger Messenger => _messenger.Value;
}

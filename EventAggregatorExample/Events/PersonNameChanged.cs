using EventAggregatorExample.Contracts;

namespace EventAggregatorExample.Events;

public record PersonNameChanged(string? OldValue, string? NewValue) : IMessage;
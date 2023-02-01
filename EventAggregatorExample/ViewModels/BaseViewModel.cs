using EventAggregatorExample.Contracts;
using EventAggregatorExample.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EventAggregatorExample.ViewModels;

public abstract class BaseViewModel : INotifyPropertyChanged
{
    protected IMessenger Messenger => CoreServices.Messenger;

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = default)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}

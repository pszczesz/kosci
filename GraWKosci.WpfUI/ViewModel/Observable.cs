using System.ComponentModel;
using System.Runtime.CompilerServices;
using GraWKosci.WpfUI.Annotations;

namespace GraWKosci.WpfUI.ViewModel
{
    public class Observable :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
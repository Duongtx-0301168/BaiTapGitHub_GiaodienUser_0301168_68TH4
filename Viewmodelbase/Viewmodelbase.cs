using System.ComponentModel;
using System.Runtime.ComplierServices;

namespace GiaodienUser.ViewModels
{
    public class ViewModelBase : InotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (equals(field, value))
                return false;

            field = value;
            OnPropertyChanged(propertyName); return true;
        }
    }
}
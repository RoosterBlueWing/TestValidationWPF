using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestValidation {

    internal class GenericViewModel : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string propertyname = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));

        private GenericViewModel _genericViewModel;
        public GenericViewModel genericViewModel {

            get => _genericViewModel;
            set {

                _genericViewModel = value;
                RaisePropertyChanged();
            }
        }
    }
}
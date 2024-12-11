using System.Windows.Input;

namespace TestValidation {

    internal class MainWindowViewModel : GenericViewModel {

        private TestObject _ViewTestObject;
        public TestObject ViewTestObject {

            get => _ViewTestObject;
            set {

                _ViewTestObject = value;
                RaisePropertyChanged();
            }
        }

        public ICommand Save => new RelayCommand(vm => {

            TestObject testObject = ViewTestObject;

            //TODO
        });

        public void Init() {

            genericViewModel = new MainWindowViewModel();

            ViewTestObject = new TestObject("test", 1, 2, 3); ;
        }
    }
}
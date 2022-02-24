using System;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVM_WpfApp1.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private string _username;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public UserViewModel()
        {
            _changeNameCommand = new DelegateCommand(OnChangeName);
        }

        //for commands: button, checkbox usw. 
        private readonly DelegateCommand _changeNameCommand;

        public ICommand ChangeNameCommand => _changeNameCommand;

        private void OnChangeName(object commandParameter)
        {
            this.Username = "Walter";
        }
    }

    public class DelegateCommand : ICommand
    {
        private readonly Action<object> _executeAction;

        public DelegateCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
        }

        public void Execute(object parameter) => _executeAction(parameter);

        public bool CanExecute(object parameter) => true;

        public event EventHandler CanExecuteChanged;
    }
}

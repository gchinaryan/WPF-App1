using System.ComponentModel;

namespace WPF_App1.Model
{
    public class User : INotifyPropertyChanged
    {
        private int _userId;
        private string _firstName;
        private string _lastName;
        private string _city;
        private string _state;
        private string _country;

        public int UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
                OnPropertyChanged("UserId");
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
                OnPropertyChanged("City");
            }
        }

        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                OnPropertyChanged("State");
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
                OnPropertyChanged("Country");
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

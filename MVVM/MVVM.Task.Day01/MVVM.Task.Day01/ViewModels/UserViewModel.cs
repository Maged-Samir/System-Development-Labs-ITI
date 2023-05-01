using GalaSoft.MvvmLight.Command;
using MVVM.Task.Day01.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVM.Task.Day01.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private User _user;
        private ObservableCollection<User> _users;
        private User _selectedUser;

        public UserViewModel()
        {
            _user = new User();
            _users = new ObservableCollection<User>();
            AddUserCommand = new RelayCommand(AddOrUpdateUser);
        }

        public string Name
        {
            get { return _user.Name; }
            set
            {
                _user.Name = value;
                RaisePropertyChanged("Name");
            }
        }

        public int Age
        {
            get { return _user.Age; }
            set
            {
                _user.Age = value;
                RaisePropertyChanged("Age");
            }
        }

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                RaisePropertyChanged("Users");
            }
        }

        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                if (_selectedUser != null)
                {
                    Name = _selectedUser.Name;
                    Age = _selectedUser.Age;

                    RaisePropertyChanged("Users");

                }
                else
                {
                    Name = string.Empty;
                    Age = 0;
                }
                RaisePropertyChanged("SelectedUser");

            }
        }

        public ICommand AddUserCommand { get; private set; }

        private void AddOrUpdateUser()
        {
            if (SelectedUser != null)
            {
                SelectedUser.Name = Name;
                SelectedUser.Age = Age;
                RaisePropertyChanged("Users");
            }
            else
            {
                Users.Add(new User { Name = Name, Age = Age });
            }
            Name = string.Empty;
            Age = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

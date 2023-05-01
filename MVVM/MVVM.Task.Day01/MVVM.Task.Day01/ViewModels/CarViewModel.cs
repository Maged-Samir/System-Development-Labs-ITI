using GalaSoft.MvvmLight.Command;
using MVVM.Task.Day01.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVM.Task.Day01.ViewModels
{
    public class CarViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Car> _cars;
        private Car _selectedCar;
        private string _model;
        private int _year;
        private string _color;
        public ICommand AddCarCommand { get; private set; }
        public CarViewModel()
        {
            _cars = new ObservableCollection<Car>()
            {
                new Car() { Id = 1, Model = "Civic", Year = 2020, Color = "Black" },
                new Car() { Id = 2, Model = "Accord", Year = 2019, Color = "White" },
                new Car() { Id = 3, Model = "CRV", Year = 2021, Color = "Red" }
            };

            AddCarCommand = new RelayCommand(AddCar);
        }

        public ObservableCollection<Car> Cars
        {
            get { return _cars; }
            set
            {
                _cars = value;
                RaisePropertyChanged("Cars");
            }
        }
        public Car SelectedCar
        {
            get { return _selectedCar; }
            set
            {
                _selectedCar = value;
                if (_selectedCar != null)
                {
                    Model = _selectedCar.Model;
                    Year = _selectedCar.Year;
                    Color = _selectedCar.Color;
                }
                else
                {
                    Model = string.Empty;
                    Year = 0;
                    Color = string.Empty;
                }
                RaisePropertyChanged("SelectedCar");
            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
                RaisePropertyChanged("Model");
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;
                RaisePropertyChanged("Year");
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
                RaisePropertyChanged("Color");
            }
        }

        private void AddCar()
        {
            Car newCar = new Car() { Id = Cars.Count + 1, Model = Model, Year = Year, Color = Color };
            Cars.Add(newCar);
            Model = string.Empty;
            Year = 0;
            Color = string.Empty;
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

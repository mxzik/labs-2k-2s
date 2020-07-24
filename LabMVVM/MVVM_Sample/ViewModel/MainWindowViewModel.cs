using System.Collections.ObjectModel;
using MVVM_Sample.Model;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.Generic;
using MVVM_Sample.Infrastructure;

namespace MVVM_Sample.ViewModel
{ 
    public class MainWindowViewModel : ViewModelBase
    {
        Student _currentStudent;
        public Student CurrentStudent
        {
            get
            {
                if (_currentStudent == null)
                    _currentStudent = new Student();
                return _currentStudent;
            }
            set
            {
                _currentStudent = value;
                OnPropertyChanged("CurrentClient");
            }
        }

        ObservableCollection<Student> _students;
        public ObservableCollection<Student> Students
        {
            get 
            {
                if (_students == null)
                    _students = ClientRepository.AllStudents;
                return _students;
            }
        }

        RelayCommand _addClientCommand;
        public ICommand AddClient
        {
            get
            {
                if (_addClientCommand == null)
                    _addClientCommand = new RelayCommand(ExecuteAddClientCommand, CanExecuteAddClientCommand);
                return _addClientCommand;
            }
        }

        public void ExecuteAddClientCommand(object parameter)
        {
            Students.Add(CurrentStudent);
            CurrentStudent = null;
        }

        public bool CanExecuteAddClientCommand(object parameter)
        {
            int AVGMark;
            bool result = int.TryParse(CurrentStudent.studentMark, out AVGMark);
            if (string.IsNullOrEmpty(CurrentStudent.FirstName) || string.IsNullOrEmpty(CurrentStudent.LastName) || string.IsNullOrEmpty(CurrentStudent.studentMark) || !result)
                return false;
                
            return true;
        }

        protected override void OnDispose()
        {
            this.Students.Clear();
        }
    }
}

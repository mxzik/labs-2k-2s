using System.Collections.ObjectModel;
using MVVM_Sample.Model;
using System.Collections.Generic;

namespace MVVM_Sample.Model
{
    public static class ClientRepository
    {
        private static ObservableCollection<Student> _students;

        public static ObservableCollection<Student> AllStudents 
        {
            get 
            {
                if (_students == null)
                    _students = GenerateClientRepository();
                return _students;
            }
        }

        private static ObservableCollection<Student> GenerateClientRepository()
        {
            ObservableCollection<Student> demoStudents = new ObservableCollection<Student>();
            demoStudents.Add(new Student("Алексей", "Продуб", "8"));
            demoStudents.Add(new Student("Николай", "Иванов", "7"));
            demoStudents.Add(new Student("Петр", "Лепин", "5"));
            return demoStudents;
        }
    }
}

namespace MVVM_Sample.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string studentMark { get; set; }

        public Student()
        {
        }

        public Student(string firstName, string lastName, string sMark)
        {
            FirstName = firstName;
            LastName = lastName;
            studentMark = sMark;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", FirstName, LastName, studentMark);
        }
    }
}

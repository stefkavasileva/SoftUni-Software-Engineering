namespace _01.Students
{
    public class Student
    {
        public static int studentCount;

        public Student(string name)
        {
            this.name = name;
            studentCount++;
        }

        public string name;
    }
}

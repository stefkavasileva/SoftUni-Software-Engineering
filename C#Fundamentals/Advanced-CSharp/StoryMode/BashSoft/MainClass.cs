public class MainClass
{
    public static void Main(string[] args)
    {
        //IOManager.TraverseDirectory(@"E:\Test");

        StudentsRepository.InitializeData();

        StudentsRepository.GetAllStudentsFromCourse("Unity");
        StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");
    }
}


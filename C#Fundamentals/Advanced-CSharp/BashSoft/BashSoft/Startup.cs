namespace BashSoft
{
    public class Startup
    {
        public static void Main()
        {
            IOManager.TraverseDirectory(@"C:\GitHubRepositories\SoftUni-Software-Engineering\C#Fundamentals\Advanced-CSharp\BashSoft\BashSoft\bin\Debug"); //=== Stacks and Queues===

            //StudentsRepository.InitializeData();
            //StudentsRepository.GetAllStudentsFromCourse("Unity"); ===== Sets and Dictionaries ====
            //StudentsRepository.GetStudentScoreFromCourese("Unity","Ivan");

            //Tester.CompareContent(@"E:\Work\Labs\test2.txt", @"E:\Worl\Labs\test3.txt");

           // IOManager.CreateDirectoryInCurrentFolder("pesho");
        }
    }
}

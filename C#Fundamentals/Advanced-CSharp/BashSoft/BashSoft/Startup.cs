namespace BashSoft
{
    public class Startup
    {
        public static void Main()
        {
            //IOManager.TraverseDirectory(@"some path"); //=== Stacks and Queues===

            //StudentsRepository.InitializeData();
            //StudentsRepository.GetAllStudentsFromCourse("Unity"); ===== Sets and Dictionaries ====
            //StudentsRepository.GetStudentScoreFromCourese("Unity","Ivan");

            //Tester.CompareContent(@"E:\Work\Labs\test2.txt", @"E:\Worl\Labs\test3.txt");

           // IOManager.CreateDirectoryInCurrentFolder("newFolder");

           // IOManager.ChangeCurrentDirectoryAbsolute(@"C:\Windows");
           // IOManager.TraverseDirectory(@"C:\Widnows");

           InputReader.StartReadingCommands();
        }
    }
}

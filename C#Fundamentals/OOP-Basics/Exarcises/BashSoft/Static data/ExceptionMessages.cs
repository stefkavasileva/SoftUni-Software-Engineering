namespace BashSoft.StaticData
{
    public static class ExceptionMessages
    {
        // public const string ExampleExceptionMessage = "Example message.";
        public const string DataAlreadyInitializedException = "Data is already initialized!";

        public const string DataNotInitializedExceptionMessage =
            "The data structure must be initialized first in order to make any operations with it.";

        public const string InexistingCourseInDataBase =
            "The course you are trying to get does not exist in the data base!";

        public const string InexistingStudentInDataBase =
            "The user name for the student you are trying to get does not exist!";

        public const string UnauthorizedAccessExceptionMessage =
            "The folder/file you are trying to get access needs a higher level of rights than you currently have.";

        public const string ComparisonOfFilesWithDifferentSizes = "Files not of equal size, certain mismatch.";

        public const string UnableToParseNumber = "The sequence you\'ve written is not a valid number.";

        public const string InvalidStudentFilter = "The given filter is not one of the following: excellent/average/poor";

        public const string InvalidComparisonQuery =
            "The comparison query you want, does not exist in the context of the current program!";

        public const string InvalidTakeQuantityParameter =
            "The take command expected does not match the format wanted!";

        public const string InvalidTakeCommand = "The take command is invalid!";

        public const string ForbiddenSymbolsInURL = "The path contains symbols that are not allowed in URL.";

        public const string InvalidScore = "The number for the score you've entered is not in the range of 0 - 100";

        public const string InvalidNumberOfScores = "The number of scores for the given course is greater than the possible.";
    }
}

namespace PhotoShare.Client.Utilities
{
    public static class ErrorMessages
    {
        public const string InvalidCommandName = "Command {0} not valid";

        // Error messages for the AcceptFriend and AddFriend commands       
        public const string NonExistentUser = "User {0} not found!";
        public const string InvalidCredentials = "Invalid credentials!";
        public const string UsersAreAlreadyFriends = "{0} is already a friend to {1}!";
        public const string NotAddedAsFriends = "{0} has not added {1} as a friend!";

        //Error messages for the AddTag and AddTagTo
        public const string ExistingTag = "Tag {0} exists!";
        public const string NonExistingTagOrAlbum = "Either tag or album do not exist!";

        //Error messages for AddTownCommand
        public const string ExistingTown = "Town {0} was already added!";

        //Error messages for CreateAlbumCommand
        public const string ExistingAlbum = "Album {0} exists!";
        public const string NonExistingColor = "Color {0} not found!";
        public const string InvalidTag = "Invalid tags!";

        //Errror messages for the DeleteUserCommand
        public const string UserIsAlreadyDeleted = "User {0} is already deleted!";

        //Error messages for the LogingCommand
        public const string InvalidUserOrPassword = "Invalid username or password!";

        //Error messages for the LogoutCommand 
        public const string LogoutNotAlowed = "You should log in first in order to logout.";

        //Error messages for the ModifyUserCommand
        public const string InvalidPropertyValue = "Value {0} not valid.{1}";
        public const string InvalidPropertyName = "{0}Property {1} not supported!";
        public const string InvalidPassword = "{0}Password must include a lower letter and a digit.{1}Invalid Password";
        public const string InvalidTown = "{0}Town {1} not found!";
        public const string InvalidProperty = "Property {0} not supported!";

        //Error messages for the RegisterUserCommand
        public const string AlreadyTakenUser = "Username {0} is already taken!";
        public const string PasswordDontMatch = "Passwords do not match!";

        //Error messages for the ShareAlbumCommand
        public const string NonExistingAlbum = "Album {0} not found!";
        public const string InvalidPermission = "Permission must be either “Owner” or “Viewer”!";

    }
}

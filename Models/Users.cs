namespace itehaProject.Models
{
    public class Users
    {
        private string userID;
        private string username;
        private string password;
        public Users(string userID, string username, string password) { 
        this.userID = userID;
            this.username = username;
            this.password = password;
        }
    }
}

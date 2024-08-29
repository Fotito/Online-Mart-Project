namespace itehaProject.Models
{
    public class Users
    {
        private string userID {get; set;}
        private string username{get; set;}
        private string password{get; set;}
        public Users(string userID, string username, string password) { 
        this.userID = userID;
            this.username = username;
            this.password = password;
        }
    }
}

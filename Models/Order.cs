namespace itehaProject.Models
{
    public class Order
    {
        private string orderID { get; set; }
        private DateOnly dateConfirmed { get; set; }
        private string status { get; set; }
        private Users Users { get; set; }

        public Order(string orderID, DateOnly dateConfirmed, string status, Users users)
        {
            this.orderID = orderID;
            this.dateConfirmed = dateConfirmed;
            this.status = status;
            this.Users = users;
        }
    }
}

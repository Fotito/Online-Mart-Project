namespace itehaProject.Models
{
    public class Order
    {
        private string orderID;
        private DateOnly dateConfirmed;
        private string status;

        public Order(string orderID, DateOnly dateConfirmed, string status)
        {
            this.orderID = orderID;
            this.dateConfirmed = dateConfirmed;
            this.status = status;
        }
    }
}

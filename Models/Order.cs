namespace itehaProject.Models
{
    public class Order
    {
        private string orderID { get; set; }
        private DateOnly dateConfirmed { get; set; }
        private string status { get; set; }

        public Order(string orderID, DateOnly dateConfirmed, string status)
        {
            this.orderID = orderID;
            this.dateConfirmed = dateConfirmed;
            this.status = status;
        }
    }
}

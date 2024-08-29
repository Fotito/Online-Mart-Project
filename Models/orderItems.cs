namespace itehaProject.Models
{
    public class orderItems
    {
        private string orderId{get; set;}
        private string productID{get; set;}
        private int quantity {get; set;}
        public orderItems(string orderId, string productID, int quantity)
        {
            this.orderId = orderId;
            this.productID = productID;
            this.quantity = quantity
        }
    }
}

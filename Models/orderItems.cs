namespace itehaProject.Models
{
    public class orderItems
    {
        private string orderId;
        private string productID;

        public orderItems(string orderId, string productID)
        {
            this.orderId = orderId;
            this.productID = productID;
        }
    }
}

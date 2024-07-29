namespace EcomAssignment3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string PurchaseHistory { get; set; }
        public string ShippingAddress { get; set; }

        public User(string email, string password, string username, string purchaseHistory, string shippingAddress)
        {
            Email = email;
            Password = password;
            Username = username;
            PurchaseHistory = purchaseHistory;
            ShippingAddress = shippingAddress;
        }
    }
}

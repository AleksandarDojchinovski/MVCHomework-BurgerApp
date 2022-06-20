namespace BurgerApp.Web.Models
{
    public class Order
    {
        public string FullName { get; set; }
        public string Address { get; set; } 
        public bool IsDelivered { get; set; }
        public List<Burger> Burgers { get; set; }
        public string Location { get; set; } 
    }
}

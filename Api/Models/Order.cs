namespace Api.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public DateTime Created { get; set; }
    }
}

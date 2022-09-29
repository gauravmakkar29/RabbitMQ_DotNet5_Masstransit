using System;

namespace BlockSeat.Model
{
    public class OrderModel
    {
        public Guid OrderId { get; set; }
        public string ProductName { get; set; }
        public string CardNumber { get; set; }
        public string UserId { get; set; }
    }
}

using System;

namespace Core.Order {
    public class OrderLine : IOrderLine {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
    }
}

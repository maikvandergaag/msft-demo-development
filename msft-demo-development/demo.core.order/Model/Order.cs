using System;
using System.Collections.Generic;

namespace Core.Order {
    public class Order : IOrder {
        public List<IOrderLine> Lines { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Guid Id { get; set; }
    }
}

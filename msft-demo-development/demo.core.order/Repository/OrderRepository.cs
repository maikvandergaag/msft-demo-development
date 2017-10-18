using Core.Order.Properties;
using System;

namespace Core.Order {
    public class OrderRepository : IOrderRepository {
        public IOrder Get(Guid Id) {

            // Get the specific order from your data repository. 
            // Settings regarding the data repository needs to be retrieved from the setting wihtin the assembly they should be copied to the main assembly.

            Log.Verbose("Get information from the order repository");

            string serviceUrl = Settings.Default.ServiceUrl;

            Order order = new Order();
            order.Id = Id;
            order.Date = DateTime.Now;
            order.Name = "Test Order";

            OrderLine line = new OrderLine();
            line.Name = "Test Line";
            line.Price = 10.00;
            line.Amount = 3;

            Log.Verbose("Received information from the order repository");

            return order;
        }

        public void Save(IOrder order) {

            Log.Verbose("Save Order information to the order repository");

            Log.Verbose($"ServiceUrl used : {Settings.Default.ServiceUrl}");

            Log.Verbose("Saved Order information to the order repository");
            // Get the specific order from your data repository. 
            // Settings regarding the data repository needs to be retrieved from the setting wihtin the assembly they should be copied to the main assembly.
        }
    }
}

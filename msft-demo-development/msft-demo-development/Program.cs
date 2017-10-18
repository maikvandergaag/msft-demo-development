using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Development {
    class Program {

        static void Main(string[] args) {

            MefConfiguration container = new MefConfiguration();
            container.Initialize();
            container.ValidateSettings();

            IOrderRepository repo = container.OrderRepository;

            IOrder order = repo.Get(Guid.NewGuid());

            Console.WriteLine(order.Id);

            repo.Save(order);

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}

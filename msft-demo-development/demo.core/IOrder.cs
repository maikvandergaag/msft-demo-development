using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {
    public interface IOrder {

        Guid Id { get; set; }

        List<IOrderLine> Lines { get; set; }

        string Name { get; set; }

        DateTime Date { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {
    public interface IOrderLine {

        string Name { get; set; }

        int Amount { get; set; }

        double Price { get; set; }
    }
}

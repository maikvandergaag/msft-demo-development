using System;
using System.ComponentModel.Composition;

namespace Core {
    [InheritedExport(typeof(IOrderRepository))]
    public interface IOrderRepository {

        IOrder Get(Guid Id);

        void Save(IOrder order);
    }
}

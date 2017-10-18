using System.ComponentModel.Composition;

namespace Core {
    [InheritedExport(typeof(IValidatable))]
    public interface IValidatable {
        void Validate();

        bool IsValid();
    }
}
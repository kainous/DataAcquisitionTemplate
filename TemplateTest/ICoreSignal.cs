using System;
using DataAcquisition;

namespace TemplateTest {
  public interface ICoreSignal<T> : ISignal<Guid, IDataPointImplementation<T>> {
    string Name { get; }
    Type ValueType { get; }
  }
}

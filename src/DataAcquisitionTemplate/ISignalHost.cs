using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcquisition {
  public interface IKeyedObject<TKey, TValue> {
    TValue this[TKey key] { get; }
  }

  public interface ISignalHost<TSignal, TId, TValue> where TSignal : ISignal<TId, TValue>  {
    IKeyedObject<TId, TSignal> Signals { get; }
  }
}

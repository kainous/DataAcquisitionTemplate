using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcquisition {

  public interface ISignalHost<TSignal, TId, TValue> where TSignal : ISignal<TId, TValue>  {
    IReadOnlyDictionary<TId, TSignal> Signals { get; }
  }
}

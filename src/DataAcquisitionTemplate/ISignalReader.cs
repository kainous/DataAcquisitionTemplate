using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcquisition {
  public interface ISignalReader<TId, TDataPoint> : INotifyPropertyChanged, IObservable<TDataPoint> {
    TId ID { get; }
    IEnumerable<TDataPoint> HistoricalPoints { get; }
  }
}

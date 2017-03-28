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

  public interface ISignal<TId, TDataPoint> : INotifyPropertyChanged, IObservable<TDataPoint> {
    TId ID { get; }

    TDataPoint UpdateValue(TDataPoint value);

    //TODO This really needs to handle threads, notifications, etc.
    IEnumerable<TDataPoint> HistoricalPoints { get; }

    ISignalReader<TId, TDataPoint> GetReader();
  }

  //public interface IReading<T> : IReading, IObservable<IDataPoint<T>> {
  //
  //}
}

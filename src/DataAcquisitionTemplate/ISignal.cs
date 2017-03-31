using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataAcquisition {
  public interface ISignal<TId, TDataPoint> : INotifyPropertyChanged, IObservable<TDataPoint> {
    TId ID { get; }

    TDataPoint UpdateValue(TDataPoint value);

    //TODO This really needs to handle threads, notifications, etc.
    IEnumerable<TDataPoint> HistoricalPoints { get; }

    ISignalReader<TId, TDataPoint> GetReader();
  }
}

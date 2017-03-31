using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcquisition {
  public interface IDataPoint<T> {
    T Value { get; }
    DateTimeOffset Timestamp { get; }
  }
}

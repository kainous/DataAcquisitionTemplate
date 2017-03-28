using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcquisition;

namespace TemplateTest {
  public interface IDataPointImplementation<T> : IDataPoint {
    T Value { get; }
    DateTimeOffset Timestamp { get; }
  }

  
}

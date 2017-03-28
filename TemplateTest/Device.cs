using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcquisition;
using System.Collections.ObjectModel;

namespace TemplateTest {
  public class MyCollection : KeyedCollection<Guid, ICoreSignal<object>> {
    protected override Guid GetKeyForItem(ICoreSignal<object> item) {
      return item.id;
    }
  }

  public interface ICoreSignalHost : ISignalHost<ICoreSignal<object>, Guid, IDataPointImplementation<object>> {

  }

  public class Device : ICoreSignalHost {
    public IKeyedObject<Guid, ICoreSignal<object>> Signals {
      get {
        throw new NotImplementedException();
      }
    }

    public Device() {
      
    }
  }
}

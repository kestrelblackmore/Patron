using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.ObserverPattern
{
    public interface IMyObserver
    {
        void Update(IMySubject subject);
    }
}

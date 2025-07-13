using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagement.Shared.Abbstraction.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get; set; }
        public int Version { get; set; }
        public bool _versionIncremented { get; set; }

        protected void IncrementVersion()
        {
            if (_versionIncremented) return;
            Version++;
            _versionIncremented = true;
        }
    }
}

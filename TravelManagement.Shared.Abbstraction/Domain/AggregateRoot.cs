﻿using System;
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


        public IEnumerable<IDomainEvent> Events => _events;

        private readonly List<IDomainEvent> _events = new();


        protected void AddEvent(IDomainEvent @event)
        {
            if (!_events.Any() && !_versionIncremented)
            {
                Version++;
                _versionIncremented = true;
            }

            _events.Add(@event);
        }

        public void ClearEvents() => _events.Clear();

        protected void IncrementVersion()
        {
            if (_versionIncremented) return;
            Version++;
            _versionIncremented = true;
        }
    }
}

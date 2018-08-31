using System;
using System.Collections.Generic;
using System.Text;
using EventSourcing.Models;

namespace EventSourcing.DomainEvents
{
    public abstract class DomainEvent
    {
        public DateTime Occurred { get; private set; }

        public DateTime Recorded { get; private set; }

        protected DomainEvent(DateTime occurred)
        {
            Occurred = occurred;
            Recorded = DateTime.Now;
        }

        internal abstract void Process();

        internal abstract void Revert();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.DomainEvents
{
    public class EventHandler:IEventHandler
    {
        public List<DomainEvent> _eventLog { get; }

        public EventHandler()
        {
            _eventLog= new List<DomainEvent>();
        }
        public void Process(DomainEvent ev)
        {
            _eventLog.Add(ev);
            ev.Process();
        }

        public void Revert(DomainEvent ev)
        {
            ev.Revert();
        }
    }
}

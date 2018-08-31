using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.DomainEvents
{
    public interface IEventHandler
    {
        void Process(DomainEvent ev);
        void Revert(DomainEvent ev);
    }
}

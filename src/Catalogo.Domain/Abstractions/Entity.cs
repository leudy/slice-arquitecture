using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Abstractions
{
   public abstract class Entity
    {
        // Common Properties
        public Guid Id { get; init; }
        protected Entity(Guid guid)
        {
            Id = guid;
        }

        // Domain Events

        private readonly List<IDomainEvent> _domainEvents = new();
        public IReadOnlyList<IDomainEvent> GetDomainEvents => _domainEvents.ToList();
        public void ClearDomainEvents() => _domainEvents.Clear();
        public void RaiseDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);




        
    }
}

using Catalogo.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Products.Events
{
    public sealed record ProductCreatedDomainEvent(Guid newproduct,string name, decimal price) : IDomainEvent;
    
    
}

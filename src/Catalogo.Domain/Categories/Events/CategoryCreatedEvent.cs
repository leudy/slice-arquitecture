using Catalogo.Domain.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Categories.Events
{
    public sealed record CategoryCreatedEvent(Guid newcategory,string name) : IDomainEvent;
    
}

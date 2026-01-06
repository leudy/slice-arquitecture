using Catalogo.Domain.Abstractions;
using Catalogo.Domain.Categories.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Categories
{
    public class Category : Entity
    {
        public string Name { get; private set; }
        public Category(Guid guid, string name) : base(guid)
        {
            Name = name;
        }
        public static Category CreateCategory(string name)
        {
            // Business logic for creating a category can be added here
            var category = new Category(Guid.NewGuid(), name);
            category.RaiseDomainEvent(new CategoryCreatedEvent(category.Id, category.Name));
            return category;
        }
    }
}

using Catalogo.Domain.Abstractions;
using Catalogo.Domain.Products.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Products
{
    public class Product : Entity
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Product(Guid guid) : base(guid)
        {
        }
        private Product(Guid guid, string name, decimal price, string description, string imageUrl) : base(guid)
        {
            Name = name;
            Price = price;
            Description = description;
            ImageUrl = imageUrl;
        }

        public static Product Create(string name, string description, string imageUrl,decimal price)
        {
            // Business logic for creating a product can be added here
            var product = new Product(Guid.NewGuid(), name, price, description, imageUrl);
            product.RaiseDomainEvent(new ProductCreatedDomainEvent(product.Id, product.Name ?? string.Empty, product.Price ?? 0));
            return product;
        }

    }
}

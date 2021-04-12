using EShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EShop.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Basket> Baskets { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductBasket> ProductBaskets { get; set; }

        public DbSet<ProductProperty> ProductProperties { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

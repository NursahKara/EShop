using EShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entities
{
    public class ProductBasket : BaseEntity
    {
        public Guid ProductId { get; set; }

        public Guid BasketId { get; set; }

        public virtual Basket Basket { get; set; }

        public virtual Product Product { get; set; }
    }
}

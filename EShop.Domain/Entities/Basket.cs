using EShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entities
{
    public class Basket : BaseEntity
    {
        public Guid UserId { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}

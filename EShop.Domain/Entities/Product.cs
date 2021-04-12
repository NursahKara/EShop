using EShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<ProductProperty> Properties { get; set; }
    }
}

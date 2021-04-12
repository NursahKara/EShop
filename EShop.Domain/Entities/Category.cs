﻿using EShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}

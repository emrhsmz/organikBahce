﻿using System;
using System.Collections.Generic;
using System.Text;

namespace organikBahce.Entities.Conrete
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
    }
}

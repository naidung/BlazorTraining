﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.DTOs
{
    public class CartItemToAddDto
    {
        public int CartID { get; set; }
        public int ProductID { get; set; }
        public int Qty { get; set; }
    }
}

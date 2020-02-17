using System;
using System.Collections.Generic;

namespace FirstMVC.Models.DB
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}

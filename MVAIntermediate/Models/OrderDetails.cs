using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVAIntermediate.Models
{
    public partial class OrderDetails
    {
        public int OrderDetailNo { get; set; }
        
        public string ItemName { get; set; }
        public string Notes { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }

        public int OrderNo { get; set; }

        [ForeignKey("OrderNo")]
        public OrderMasters OrderMaster { get; set; }
    }
}

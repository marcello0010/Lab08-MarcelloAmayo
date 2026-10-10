using System;
using System.Collections.Generic;

namespace Lab08__MarcelloAmayo.Models;

public partial class Order
{
    public int Orderid { get; set; }

    public int Clientid { get; set; }

    public DateTime Orderdate { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<OrderDetail> Orderdetails { get; set; } = new List<OrderDetail>();
}
using System;
using System.Collections.Generic;

namespace BussinesObjects.Models;

public partial class Order
{
    public int Id { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string TotalMoney { get; set; } = null!;

    public byte Status { get; set; }

    public virtual Account CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<OrderDecor> OrderDecors { get; set; } = new List<OrderDecor>();

    public virtual ICollection<OrderFood> OrderFoods { get; set; } = new List<OrderFood>();

    public virtual ICollection<OrderRoom> OrderRooms { get; set; } = new List<OrderRoom>();
}

using System;
using System.Collections.Generic;

namespace BussinesObjects.Models;

public partial class Decor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    public decimal Price { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public virtual Account CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<OrderDecor> OrderDecors { get; set; } = new List<OrderDecor>();
}

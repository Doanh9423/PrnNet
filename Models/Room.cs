using System;
using System.Collections.Generic;

namespace BussinesObjects.Models;

public partial class Room
{
    public int Id { get; set; }

    public string RoomNumber { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte Size { get; set; }

    public int MaxCapacity { get; set; }

    public byte Status { get; set; }

    public decimal Price { get; set; }

    public string Note { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public virtual Account CreatedByNavigation { get; set; } = null!;

    public virtual OrderRoom? OrderRoom { get; set; }
}

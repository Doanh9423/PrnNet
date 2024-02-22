using System;
using System.Collections.Generic;

namespace BussinesObjects.Models;

public partial class Package
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal Price { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public virtual ICollection<AccountPack> AccountPacks { get; set; } = new List<AccountPack>();

    public virtual Account CreatedByNavigation { get; set; } = null!;
}

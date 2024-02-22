using System;
using System.Collections.Generic;

namespace BussinesObjects.Models;

public partial class AccountPack
{
    public int Id { get; set; }

    public int IdPack { get; set; }

    public int IdAccount { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal ActualPrice { get; set; }

    public byte Status { get; set; }

    public virtual Account IdAccountNavigation { get; set; } = null!;

    public virtual Package IdPackNavigation { get; set; } = null!;
}

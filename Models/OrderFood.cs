using System;
using System.Collections.Generic;

namespace BussinesObjects.Models;

public partial class OrderFood
{
    public int Id { get; set; }

    public int IdFood { get; set; }

    public int IdOrder { get; set; }

    public int Quality { get; set; }

    public decimal TotalMoney { get; set; }

    public virtual Food IdFoodNavigation { get; set; } = null!;

    public virtual Order IdOrderNavigation { get; set; } = null!;
}

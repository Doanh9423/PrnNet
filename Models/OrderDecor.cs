﻿using System;
using System.Collections.Generic;

namespace BussinesObjects.Models;

public partial class OrderDecor
{
    public int Id { get; set; }

    public int IdOrder { get; set; }

    public int IdDecor { get; set; }

    public int Quality { get; set; }

    public decimal TotalPrice { get; set; }

    public virtual Decor IdDecorNavigation { get; set; } = null!;

    public virtual Order IdOrderNavigation { get; set; } = null!;
}

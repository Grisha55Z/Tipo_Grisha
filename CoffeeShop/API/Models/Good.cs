﻿using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Good
{
    public int GoodId { get; set; }

    public string Name { get; set; } = null!;

    public string Price { get; set; } = null!;
}

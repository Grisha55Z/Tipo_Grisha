using System;
using System.Collections.Generic;

namespace AvaloniaApplication4.Models;

public partial class Dormitory
{
    public int Room { get; set; }

    public int? Floor { get; set; }

    public virtual Boy? Boy { get; set; }

    public virtual Girl? Girl { get; set; }
}

﻿using System;
using System.Collections.Generic;

namespace BusinessObjects.Entities;

public partial class Account
{
    public int AccountId { get; set; }

    public string? AcountName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Role? Role { get; set; }
}

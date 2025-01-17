﻿using System;
using System.Collections.Generic;

namespace backend.DatabaseModel
{
    public partial class User
    {
        public User()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Salary { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

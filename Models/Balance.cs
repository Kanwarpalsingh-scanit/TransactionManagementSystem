using System;
using System.Collections.Generic;

namespace TransactionManagementSystem.Models;

public partial class Balance
{
    public int Id { get; set; }

    public decimal? TotalBalance { get; set; }

    public DateTime? UpdatedOn { get; set; }
}

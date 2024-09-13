using System;
using System.Collections.Generic;

namespace TransactionManagementSystem.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public string? TransactionType { get; set; }
    public string? TransactionDescription { get; set; }

    public decimal? TransctionAmount { get; set; }

    public decimal? RunningBalance { get; set; }

    public DateTime? CreatedOn { get; set; }
}

﻿using PersonalFinanceApp.Data.Interfaces;

namespace PersonalFinanceApp.Data.Entities;

public class Expense : IBaseEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
    public string? Comment { get; set; }
    public DateTime Date { get; set; }

    virtual public ExpenseCategory Category { get; set; }
}

﻿namespace PersonalFinanceApp.Services.Models;

public class AddExpenseDto
{
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
    public string? Comment { get; set; }
    public DateTime Date { get; set; }
}

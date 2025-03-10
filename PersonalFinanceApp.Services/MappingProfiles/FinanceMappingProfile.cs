﻿using AutoMapper;
using PersonalFinanceApp.Data.Entities;
using PersonalFinanceApp.Services.Enums;
using PersonalFinanceApp.Services.Models;
using PersonalFinanceApp.Services.Models.User;

namespace PersonalFinanceApp.Services.MappingProfiles;

public class FinanceMappingProfile : Profile
{
    public FinanceMappingProfile()
    {
        // User
        CreateMap<RegisterUserDto, User>();

        // Categories
        CreateMap<IncomeCategory, IncomeCategoryDto>();
        CreateMap<ExpenseCategory, ExpenseCategoryDto>();

        // Incomes/Expenses
        CreateMap<Income, IncomeDto>();
        CreateMap<AddIncomeDto, Income>();
        CreateMap<IncomeDto, IncomeExpenseDto>().ForMember(d => d.Type, c => c.MapFrom(s => IncomeExpenseType.Income));

        CreateMap<Expense, ExpenseDto>();
        CreateMap<AddExpenseDto, Expense>();
        CreateMap<ExpenseDto, IncomeExpenseDto>().ForMember(d => d.Type, c => c.MapFrom(s => IncomeExpenseType.Expense));

        // Regular Incomes/Expenses
        CreateMap<AddRegularIncomeDto, RegularIncome>();
        CreateMap<RegularIncome, RegularIncomeDto>();
        CreateMap<RegularIncome, Income>()
            .ForMember(d => d.Id, c => c.Ignore())
            .ForMember(d => d.Date, c => c.MapFrom(s => s.LastDateAdded));

        CreateMap<AddRegularExpenseDto, RegularExpense>();
        CreateMap<RegularExpense, RegularExpenseDto>();
        CreateMap<RegularExpense, Expense>()
            .ForMember(d => d.Id, c => c.Ignore())
            .ForMember(d => d.Date, c => c.MapFrom(s => s.LastDateAdded));
    }
}

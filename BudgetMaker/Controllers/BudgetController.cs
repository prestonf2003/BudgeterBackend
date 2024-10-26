using Microsoft.AspNetCore.Mvc;

namespace BudgetMaker.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BudgetController: ControllerBase
{

    [HttpPost]
    public Budget GetBudget(PersonalInfo info)
    {
        double bills = (info.Bills.Sum(b => b)) / 4;
        double savings = info.NetIncome * 0.2;
        double rent = info.HousingCost / 4;
        double spendingMoney = info.NetIncome - bills - savings -rent;
        return new Budget(spendingMoney, bills, rent, savings);

    }
    
}
namespace BudgetMaker;

public class Budget
{
    public double SpendingMoney { get; set; }
    
    public double BillMoney { get; set; }
    
    public double RentMoney { get; set; }
    
    public double Savings { get; set; }

    public Budget(double spendingMoney, double billMoney, double rentMoney, double savings)
    {
        SpendingMoney = spendingMoney;
        BillMoney = billMoney;
        RentMoney = rentMoney;
        Savings = savings;
        
    }
}
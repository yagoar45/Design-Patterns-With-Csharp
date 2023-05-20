public class ISSTruth : ITax
{
    public double Calc(BudgetTruth budget)
    {   
        return budget.Value * 0.06;
    }
}
public class ICMSTruth : ITax
{
    public double Calc(BudgetTruth budget)
    {   
        return budget.Value * 0.05;
    }
}
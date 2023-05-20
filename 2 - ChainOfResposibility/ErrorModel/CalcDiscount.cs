using DesignPatterns._2___ChainOfResposibility.ErrorModel;

public class CalcDiscount
{
    public double Calc(BudgetTruth budget)
    {
        double discount = new CalcDiscountFor5ItensTruth().CalcDiscount(budget);

        if(discount.Equals(0))
        {
            discount = new DiscountForMore500DolsTruth().CalcDiscount(budget);
        }

        // until the discount have a value...

        return discount;
    }
}
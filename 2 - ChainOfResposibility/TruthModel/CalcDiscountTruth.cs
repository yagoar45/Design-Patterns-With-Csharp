
namespace DesignPatterns._2___ChainOfResposibility.TruthModel;

public class CalcDiscountTruth : IDiscount
{
    public IDiscount NextRule { get; set; } 

    public double Discount(BudgetTruth budget)
    {
        // example of implemetation in the domain 

        var d1 = new CalcDiscountFor5ItensTruth();
        var d2 = new CalcDiscountForMore500DolsTruth();
        var d3 = new CalcWithOutDiscount(); 

        d1.NextRule = d2;
        d2.NextRule = d3;

        return d1.Discount(budget);
    }
}
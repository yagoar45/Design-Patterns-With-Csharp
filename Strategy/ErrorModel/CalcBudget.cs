public class CalcBuget  
{
    public void MakeCal(Budget budget, string tax)
    {
        if ("ICMS".Equals(tax))
        {
            // double icms = budget.Value * 0.1;
            double icms = new ICMS().CalcICMS(budget);
            Console.WriteLine($"O valor do ICMS é: {icms}R$");
        }
        else if ("ISS".Equals(tax))
        {
            // double iss = budget.Value * 0.06;
            double  iss = new ISS().CalcISS(budget);
            Console.WriteLine($"O valor do ISS é: {iss}R$");
        }
    }
}
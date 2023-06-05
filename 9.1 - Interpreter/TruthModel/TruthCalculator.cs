


using System.Linq.Expressions;

namespace DesignPatterns._9._1___Interpreter.TruthModel
{
    public class TruthCalculator
    {
        public static void Test()
        {
            Expression sum = Expression.Add(Expression.Constant(30), Expression.Constant(12));

            Func<double> sumFunc = Expression.Lambda<Func<double>>(sum).Compile();

     

            Console.WriteLine(sumFunc());
        }

    }
}

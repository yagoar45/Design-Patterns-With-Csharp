
namespace DesignPatterns._9._1___Interpreter.ErrorModel
{
    public class Sum : IMathExpression
    {
        private  double X; 
        private  double Y;

        public double Calc()
        {
            return X + Y;
        }

        public Sum(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}

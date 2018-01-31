namespace BasicWCF
{
    public class MathService : IMath
    {
        public double Add(double A, double B)
        {
            return A + B;
        }

        public double Multiply(double A, double B)
        {
            return A * B;
        }
    }
}

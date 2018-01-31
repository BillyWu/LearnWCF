using System.ServiceModel;

namespace BasicWCF
{
    [ServiceContract]
    public interface IMath
    {
        [OperationContract]
        double Add(double A, double B);

        [OperationContract]
        double Multiply(double A, double B);
    }
}

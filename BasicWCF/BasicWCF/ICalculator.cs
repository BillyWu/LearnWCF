using System.ServiceModel;

namespace BasicWCF
{
    //This interface defines the input and output types by applying the ServiceContractAttribute class to the interface
    [ServiceContract]
    public interface ICalculator
    {
        // the OperationContractAttribute class to the methods that you want to expose.
        //The methods that have the OperationContractAttribute class applied use a request-reply message pattern by default. 
        [OperationContract]
        double Add(double n1, double n2);
        [OperationContract]
        double Subtract(double n1, double n2);
        [OperationContract]
        double Multiply(double n1, double n2);
        [OperationContract]
        double Divide(double n1, double n2);
    }
}

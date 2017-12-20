using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface ICandidateService
    {
        [OperationContract]
        ushort GetCandidatesCount();

        [OperationContract]
        ushort GetTotalSalary();
    }
}

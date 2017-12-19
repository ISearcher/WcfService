using System.ServiceModel;
using WcfService.Entity;

namespace WcfService
{
    [ServiceContract]
    public interface ICandidateService
    {
        [OperationContract]
        void AddCandidate(CandidateInfo candidate);

        [OperationContract]
        void RemoveCandidate(CandidateInfo candidate);

        [OperationContract]
        void UpdateCandidate(CandidateInfo candidate);

        [OperationContract]
        ushort GetCandidatesCount();

        [OperationContract]
        ushort GetTotalSalary();
    }
}

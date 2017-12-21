using System.ServiceModel;
using WcfService.Entity;

namespace WcfService
{
    [ServiceContract]
    public interface ICandidateService
    {
        [OperationContract]
        int GetCandidatesCount();

        [OperationContract]
        int GetTotalSalary();

        [OperationContract]
        void AddCandidate(CandidateInfo candidate);

        [OperationContract]
        void RemoveCandidate(CandidateInfo candidate);

        [OperationContract]
        void UpdateCandidate(CandidateInfo candidate);
    }
}

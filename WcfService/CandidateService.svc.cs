using System.Linq;
using System.ServiceModel.Web;
using Castle.Core.Internal;
using WcfService.Entity;

namespace WcfService
{
    public class CandidateService : ICandidateService
    {
        private readonly IRepository _repository;

        public CandidateService(IRepository repository)
        {
            _repository = repository;
        }

        [WebGet]
        public int GetCandidatesCount()
        {
            return _repository.GetAllCandidates().Count;
        }

        [WebGet]
        public int GetTotalSalary()
        {
            return _repository.GetAllCandidates().Sum(t => t.Salary);
        }

        [WebInvoke(Method = "POST")]
        public void AddCandidate(CandidateInfo candidate)
        {
            if (!BasicValidation(candidate))
            {
                return;
            }

            _repository.Add(candidate);
        }

        [WebInvoke(Method = "DELETE")]
        public void RemoveCandidate(CandidateInfo candidate)
        {
            if (!BasicValidation(candidate))
            {
                return;
            }

            _repository.Delete(candidate);
        }

        [WebInvoke(Method = "PUT")]
        public void UpdateCandidate(CandidateInfo candidate)
        {
            if (!BasicValidation(candidate))
            {
                return;
            }

            _repository.Update(candidate);
        }

        private bool BasicValidation(CandidateInfo candidate)
        {
            if (candidate == null || candidate.Name.IsNullOrEmpty())
            {
                return false;
            }

            return true;
        }
    }
}

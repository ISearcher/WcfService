using System.ServiceModel.Web;
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
        public ushort GetCandidatesCount()
        {
            return 42;
        }

        [WebGet]
        public ushort GetTotalSalary()
        {
            return 43;
        }
    }
}

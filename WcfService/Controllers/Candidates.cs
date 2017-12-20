using System;
using System.ServiceModel.Web;
using System.Web.Mvc;
using WcfService.Entity;

namespace WcfService.Controllers
{
    public class Candidates : Controller
    {
        private readonly IRepository _repository;

        public Candidates(IRepository repository)
        {
            _repository = repository;
        }

        [WebGet]
        public ushort Do()
        {
            return 42;
        }

        [WebInvoke(Method = "POST")]
        public void AddCandidate(CandidateInfo candidate)
        {
            throw new NotImplementedException();
        }

        [WebInvoke(Method = "DELETE")]
        public void RemoveCandidate(CandidateInfo candidate)
        {
            throw new NotImplementedException();
        }

        [WebInvoke(Method = "PUT")]
        public void UpdateCandidate(CandidateInfo candidate)
        {
            throw new NotImplementedException();
        }
    }
}
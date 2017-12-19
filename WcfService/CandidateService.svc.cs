using System;
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

        public void AddCandidate(CandidateInfo candidate)
        {
            throw new NotImplementedException();
        }

        public void RemoveCandidate(CandidateInfo candidate)
        {
            throw new NotImplementedException();
        }

        public void UpdateCandidate(CandidateInfo candidate)
        {
            throw new NotImplementedException();
        }

        public ushort GetCandidatesCount()
        {
            throw new NotImplementedException();
        }

        public ushort GetTotalSalary()
        {
            throw new NotImplementedException();
        }
    }
}

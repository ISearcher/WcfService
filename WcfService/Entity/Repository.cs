using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WcfService.Infrastructure;

namespace WcfService.Entity
{
    public interface IRepository
    {
        void Add(CandidateInfo candidate);
        void Update(CandidateInfo candidate);
        void Delete(CandidateInfo candidate);

        List<CandidateInfo> GetAllCandidates();
    }

    public class Repository : IRepository
    {
        private readonly IDbSet<CandidateInfo> _dbChache;
        private readonly IDbFactory _dbFactory;

        private DataContext _dataContext;
        private DataContext DbContext => _dataContext ?? (_dataContext = _dbFactory.Init());

        public Repository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
            _dbChache = DbContext.Set<CandidateInfo>();
            _dbChache.Load();
        }

        public void Add(CandidateInfo candidate)
        {
            if (!Exists(candidate))
            {
                _dbChache.Add(candidate);
                DbContext.SaveChanges();
            }
        }

        public void Update(CandidateInfo candidate)
        {
            if (Exists(candidate))
            {
                var cnd = DbContext.Candidates.Single(t => t.Id == candidate.Id);
                DbContext.Entry(cnd).State = EntityState.Modified;
                DbContext.SaveChanges();
            }
        }

        public void Delete(CandidateInfo candidate)
        {
            if (Exists(candidate))
            {
                var cnd = DbContext.Candidates.Single(t => t.Id == candidate.Id);
                DbContext.Candidates.Remove(cnd);
                DbContext.SaveChanges();
            }
        }

        public List<CandidateInfo> GetAllCandidates()
        {
            return _dbChache.Local.ToList();
        }

        private bool Exists(CandidateInfo candidate)
        {
            return _dbChache.Local.Any(t => t.Id == candidate.Id);
        }
    }
}
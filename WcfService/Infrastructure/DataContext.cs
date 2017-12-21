using System.Data.Entity;
using WcfService.Entity;

namespace WcfService.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("CandidatesDB")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<CandidateInfo> Candidates { get; set; }
    }
}
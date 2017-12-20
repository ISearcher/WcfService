using System.Data.Entity;

namespace WcfService.Entity
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
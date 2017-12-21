namespace WcfService.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        DataContext _dbContext;

        public DataContext Init()
        {
            return _dbContext ?? (_dbContext = new DataContext());
        }

        protected override void InternalDispose()
        {
            _dbContext?.Dispose();
        }
    }
}
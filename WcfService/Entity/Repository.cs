namespace WcfService.Entity
{
    public interface IRepository
    {
    }

    public class Repository : IRepository
    {
        private int _value;

        public Repository()
        {
            _value = 42;
        }
    }
}
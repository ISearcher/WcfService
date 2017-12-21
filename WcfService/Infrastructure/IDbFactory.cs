using System;

namespace WcfService.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        DataContext Init();
    }
}
using System;

namespace WcfService.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool _isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed && disposing)
            {
                InternalDispose();
            }

            _isDisposed = true;
        }

        protected virtual void InternalDispose() {}
    }
}
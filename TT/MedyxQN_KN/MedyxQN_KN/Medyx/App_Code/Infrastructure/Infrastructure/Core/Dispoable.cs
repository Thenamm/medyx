using System;

namespace Infrastructure.Core
{
    public class Dispoable : IDisposable
    {
        private bool isDisposed;

        ~Dispoable()
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
            if (!isDisposed && disposing)
            {
                // Cleanup up manager object
                DisposeCore();
            }
            isDisposed = true;
        }

        protected virtual void DisposeCore()
        {
        }
    }
}
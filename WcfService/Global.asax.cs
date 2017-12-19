using Ninject;
using Ninject.Web.Common.WebHost;
using WcfService.Utility;

namespace WcfService
{
    public class Global : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            return new StandardKernel(new WcfNinjectModule());
        }
    }
}
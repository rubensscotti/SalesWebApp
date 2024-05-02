using SalesWebApp.Data;
using SalesWebApp.Models;

namespace SalesWebApp.Services
{
    public class SellerService
    {
        private readonly SalesWebAppContext _appContext;

        public SellerService(SalesWebAppContext appContext)
        {
            _appContext = appContext;
        }

        public List<Seller> FindAll()
        {
            return _appContext.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _appContext.Add(obj);
            _appContext.SaveChanges();
        }
    }
}

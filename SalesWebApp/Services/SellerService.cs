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

        public Seller FindById(int id)
        {
            return _appContext.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _appContext.Seller.Find(id);
            _appContext.Seller.Remove(obj);
            _appContext.SaveChanges();
        }
    }
}

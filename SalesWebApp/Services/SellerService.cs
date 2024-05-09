using Microsoft.EntityFrameworkCore;
using SalesWebApp.Data;
using SalesWebApp.Models;
using SalesWebApp.Services.Exceptions;

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
            return _appContext.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _appContext.Seller.Find(id);
            _appContext.Seller.Remove(obj);
            _appContext.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if(!_appContext.Seller.Any(x =>  x.Id == obj.Id))
            {
                throw new Exception("Id not found");
            }
            try
            {
                _appContext.Update(obj);
                _appContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbConcurrencyException(ex.Message);
            }
        }
    }
}

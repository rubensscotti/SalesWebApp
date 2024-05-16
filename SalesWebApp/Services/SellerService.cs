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

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _appContext.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller obj)
        {
            _appContext.Add(obj);
            await _appContext.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _appContext.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _appContext.Seller.FindAsync(id);
            _appContext.Seller.Remove(obj);
            await _appContext.SaveChangesAsync();
        }

        public async Task Update(Seller obj)
        {
            bool hasAny = await _appContext.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new Exception("Id not found");
            }
            try
            {
                _appContext.Update(obj);
                await _appContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbConcurrencyException(ex.Message);
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShawarmaX.Models
{
    public class ShawarmaRepository : IShawarmaRepository
    {
        private readonly AppDbContext _appDbContext;

        public ShawarmaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Shawarma> AllShawarma
        {
            get
            {
                return _appDbContext.Shawarmas.Include(c => c.Category);
            }

        }

        public IEnumerable<Shawarma> Offers
        {
            get
            {
                return _appDbContext.Shawarmas.Include(c => c.Category).Where(p => p.IsOffer);
            }
        }

        public Shawarma GetPieById(int shawarmaId)
        {
            return _appDbContext.Shawarmas.FirstOrDefault(p => p.Id == shawarmaId);
        }
    }
}

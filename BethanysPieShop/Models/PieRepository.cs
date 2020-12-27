using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;
        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies 
        {
            get 
            {
                return _appDbContext.Pies.Include(n => n.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _appDbContext.Pies.Include(n => n.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int PieId)
        {
            return _appDbContext.Pies.FirstOrDefault(x => x.PieId == PieId); 
        }
    }
}

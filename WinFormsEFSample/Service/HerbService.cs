using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WinFormsEFSample.DataAccess;
using WinFormsEFSample.DataAccess.Models;
using WinFormsEFSample.Service.Contract;

namespace WinFormsEFSample.Service
{
    public class HerbService : IHerbService
    {
        private readonly HerbDbContext _dbContext;

        public HerbService(HerbDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Herb>> GetAllHerbs()
        {
            // Fake database loading time
            await Task.Delay(3000);

            return await _dbContext.Herb
                .Include(herb => herb.Seasons)
                .OrderBy(herb => herb.Name)
                .ToListAsync();
        }

        public async Task<Herb> GetHerbById(Guid id)
        {
            // Fake database loading time
            await Task.Delay(3000);

            return await _dbContext.Herb
                .Include(herb => herb.Seasons)
                .FirstOrDefaultAsync(herb => herb.Id == id);
        }
    }
}

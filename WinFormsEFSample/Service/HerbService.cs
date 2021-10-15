using System;
using System.Collections.Generic;
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
            return await _dbContext.Herb.ToListAsync();
        }

        public async Task<Herb> GetHerbById(Guid id)
        {
            return await _dbContext.Herb.FirstOrDefaultAsync(herb => herb.Id == id);
        }
    }
}

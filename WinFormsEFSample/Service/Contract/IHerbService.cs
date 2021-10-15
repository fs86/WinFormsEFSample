using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WinFormsEFSample.DataAccess.Models;

namespace WinFormsEFSample.Service.Contract
{
    public interface IHerbService
    {
        Task<IEnumerable<Herb>> GetAllHerbs();
        Task<Herb> GetHerbById(Guid id);
    }
}

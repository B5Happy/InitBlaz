using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InitBlaz.Server.Model;
using Microsoft.EntityFrameworkCore;

namespace InitBlaz.Server.Data
{
    /// <summary>
    /// Instrument repository.
    /// </summary>
    public class InstrumentRepository : IInstrumentRepository
    {
        private readonly DataContext _context;
 

        public InstrumentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Instrument>> GetInstruments()
        {
            return await _context.Instruments.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<Instrument> GetInstrument(int id)
        {
            return await _context.Instruments.Where(z => z.Id == id).FirstOrDefaultAsync();
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}

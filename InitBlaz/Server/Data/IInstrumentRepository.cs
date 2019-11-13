using InitBlaz.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InitBlaz.Server.Data
{
    /// <summary>
    /// Instrument repository interface
    /// </summary>
    public interface IInstrumentRepository
    {
       
        Task<List<Instrument>> GetInstruments();

        Task<Instrument> GetInstrument(int id);

        void Delete<T>(T entity) where T : class;

        void Add<T>(T entity) where T : class;

        Task<bool> SaveAll();

    }
}

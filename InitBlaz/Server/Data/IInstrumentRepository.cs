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
    }
}

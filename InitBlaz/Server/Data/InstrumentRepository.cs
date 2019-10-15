﻿using System;
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
    }
}
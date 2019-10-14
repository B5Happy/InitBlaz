using InitBlaz.Server.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitBlaz.Server.Data
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedInstrument()
        {
            var instrumentsData = System.IO.File.ReadAllText("Data/Seed/InstrumentSeed.json", Encoding.GetEncoding("iso-8859-1"));

            var instruments = JsonConvert.DeserializeObject<List<Instrument>>(instrumentsData);

            foreach (var instrument in instruments)
            {
                if(! _context.Instruments.Any(x => x.Name == instrument.Name))
                {
                    _context.Instruments.Add(instrument);
                }
            }

            _context.SaveChanges();
        }
    }
}

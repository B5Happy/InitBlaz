using AutoMapper;
using InitBlaz.Server.Model;
using InitBlaz.Shared.Dto.Output.Instrument.ForList;
using InitBlaz.Shared.Dto.Output.Instrument.ForSingleSelect;

namespace InitBlaz.Server.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Instrument, DtoOutputInstrumentForList>();
            CreateMap<Instrument, DtoOutputInstrumentForSingleSelect>();
        }
    }
}

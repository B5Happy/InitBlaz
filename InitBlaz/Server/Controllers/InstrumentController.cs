using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using InitBlaz.Server.Data;
using InitBlaz.Shared.Dto.Output.Instrument.ForList;
using InitBlaz.Shared.Dto.Output.Instrument.ForSingleSelect;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace InitBlaz.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [OpenApiTag("Instrument", Description = "Instrument controller")]
    public class InstrumentController : ControllerBase
    {
        private readonly IInstrumentRepository _repository;
        private readonly IMapper _mapper;

        public InstrumentController(IInstrumentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, typeof(List<DtoOutputInstrumentForList>), Description = "Ok")]
        public async Task<IActionResult> GetInstrument()
        {
            var items = await _repository.GetInstruments();
            var itemsDto = _mapper.Map<List<DtoOutputInstrumentForList>>(items);
            return Ok(itemsDto);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(DtoOutputInstrumentForSingleSelect), Description = "Ok")]
        public async Task<IActionResult> GetInstrument(int id)
        {
            var items = await _repository.GetInstrument(id);
            var itemsDto = _mapper.Map<DtoOutputInstrumentForSingleSelect>(items);
            return Ok(itemsDto);
        }

    }
}
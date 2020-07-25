using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Commander.Models;
using Commander.Repository;
using AutoMapper;
using Commander.Dtos;

namespace Commander.Controllers
{

    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _commanderService;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo commanderService, IMapper mapper)
        {
            _commanderService = commanderService;
            _mapper = mapper;
        }

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandItems = _commanderService.GetAllCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }

        // GET api/commands/{id}
        [HttpGet("{id}", Name = "GetCommandById")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var commandItem = _commanderService.GetCommandById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }

        // POST api/commands/create
        [HttpPost("create")]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        {
            var commandModel = _mapper.Map<Command>(commandCreateDto);
            _commanderService.CreateCommand(commandModel);
            _commanderService.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);
            // return Ok(commandReadDto);
            return CreatedAtRoute(nameof(GetCommandById), new { Id = commandReadDto.Id }, commandReadDto);
        }

        // PUT api/commands/update/{id}
        [HttpPut("update/{id}")]
        public ActionResult UpdateCommand(int id, CommandUpdateDto commandUpdateDto)
        {
            var commandModelFromService = _commanderService.GetCommandById(id);
            if (commandModelFromService == null)
            {
                return NotFound();
            }

            _mapper.Map(commandUpdateDto, commandModelFromService);
            _commanderService.UpdateCommand(commandModelFromService);
            _commanderService.SaveChanges();

            return NoContent();
        }

    }
}
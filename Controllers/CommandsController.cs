using System.Collections.Generic;
using CommanderApi.Data;
using CommanderApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommanderApi.Controllers
{
    // api/Commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        // GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
        } 

        // GET api/commands/{id} 
        [HttpGet("{id:int}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}
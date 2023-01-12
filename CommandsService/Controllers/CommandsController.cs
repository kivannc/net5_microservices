using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandsService.Data;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [ApiController]
    [Route("api/c/[controller]")]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandRepo _repository;

        public CommandsController(ICommandRepo repository)
        {
            _repository = repository;
        }

    }
}
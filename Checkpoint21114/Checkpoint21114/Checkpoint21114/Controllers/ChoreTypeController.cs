using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Checkpoint21114.ApiModels;
using CheckPoint21114.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint21114.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoreTypeController : ControllerBase
    {

        private readonly IChoreTypeService _choreTypeService;


        public ChoreTypeController(IChoreTypeService choreTypeService)
        {
            _choreTypeService = choreTypeService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            var choreTypeModels = _choreTypeService.GetAll()

           .ToApiModels();

            return Ok(choreTypeModels);

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var choreType = _choreTypeService.Get(id).ToApiModel();


            if (choreType == null) return NotFound();
            return Ok(choreType);
        }



      

    

    }
}
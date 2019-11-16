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
    public class ChoreController : ControllerBase
    {

           private readonly IChoreService _choreService;


        public ChoreController(IChoreService choreService)
        {
            _choreService = choreService;
        }

            // GET: api/<controller>
            [HttpGet]
            public IActionResult Get()
        {
            var choreModels = _choreService.GetAll()

           .ToApiModels();

            return Ok(choreModels);

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var chore = _choreService.Get(id).ToApiModel();
            

            if (chore == null) return NotFound();
            return Ok(chore);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]ChoreModel newChore)
        {
            try {
                _choreService.Add(newChore.ToDomainModel());
            

        }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddChore", ex.GetBaseException().Message);
                return BadRequest(ModelState);
    }

            return CreatedAtAction("Get", new { Id = newChore.Id}, newChore);

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]ChoreModel updatedChore)
        {

            var chore = _choreService.Update(updatedChore.ToDomainModel());
            if (chore == null) return NotFound();
            //UNSURE
            return Ok(chore.ToApiModel());
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var chore = _choreService.Get(id);
            if (chore == null) return NotFound();
            _choreService.Remove(chore);
            return NoContent();

        }

    }
}
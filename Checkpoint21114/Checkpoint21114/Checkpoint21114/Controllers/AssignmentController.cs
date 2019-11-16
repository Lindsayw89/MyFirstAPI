/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckPoint21114.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint21114.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {

        private readonly IAssignmentService _assignmentService;


        public AssignmentController(AssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            var assignmentModels = _assignmentService.GetAll()

           .ToApiModels();

            return Ok(assignmentModels);

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var assignment = _assignmentService.Get(id).ToApiModel();


            if (assignment == null) return NotFound();
            return Ok(assignment);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]AssignmentModel newAssignment)
        {
            try
            {
                _assignmentService.Add(newAssignmentType.ToDomainModel());


            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddAssignment", ex.GetBaseException().Message);
                return BadRequest(ModelState);
            }

            return CreatedAtAction("Get", new { Id = newAssignment.Id }, newAssignment);

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]AssignmentModel updatedAssignment)
        {

            var assignment = _assignmentService.Update(updatedAssignment.ToDomainModel());
            if (assignment == null) return NotFound();
            //UNSURE
            return Ok(assignment.ToApiModel());
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var assignment = _assignmentService.Get(id);
            if (assignment == null) return NotFound();
            _assignmentService.Remove(assignmentType);
            return NoContent();

        }

    }
}*/
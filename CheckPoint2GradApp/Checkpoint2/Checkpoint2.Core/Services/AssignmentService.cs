using Checkpoint2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint2.Core.Services
{
    public class AssignmentService : IAssignmentService
    {

        private IAssignmentRepository _assignmentRepo;

        public AssignmentService(IAssignmentRepository AssignmentRepo)
        {
            _assignmentRepo = AssignmentRepo;
        }

        public Assignment Add(Assignment Assignment)
        {
            // TODO: implement add
            _assignmentRepo.Add(Assignment);
            return Assignment;
        }

        public Assignment Get(int id)
        {
            // TODO: return the specified ActivityType using Find()
            return _assignmentRepo.Get(id);
        }

        public IEnumerable<Assignment> GetAll()
        {
            // TODO: return all ActivityTypes using ToList()
            return _assignmentRepo.GetAll();
        }

        public Assignment Update(Assignment updatedActivityType)
        {
            // update the todo and save
            var ActivityType = _assignmentRepo.Update(updatedActivityType);
            return ActivityType;
        }

        public void Remove(Assignment ActivityType)
        {
            // TODO: remove the ActivityType
            _assignmentRepo.Remove(ActivityType);
        }
    }
}

using Checkpoint2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint2.Core.Services
{
    public class IAssignmentService
    {
        Assignment Add(Assignment Assignment);
        Assignment Get(int id);
        IEnumerable<Assignment> GetAll();
        void Remove(Assignment ActivityType);
        Assignment Update(Assignment updatedAssignment);
    }
}

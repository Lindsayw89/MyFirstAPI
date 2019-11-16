using Checkpoint2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint2.Core.Services
{
    public class IAssignmentRepository
    {

        // create
        Assignment Add(Assignment todo);
        // read
        Assignment Get(int id);
        // update
        Assignment Update(Assignment assignment);
        // delete
        void Remove(Assignment assignment);
        // list
        IEnumerable<Assignment> GetAll();
    }
}

using CheckPoint21114.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint21114.Core.Services
{
   public interface IAssignmentRepository
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

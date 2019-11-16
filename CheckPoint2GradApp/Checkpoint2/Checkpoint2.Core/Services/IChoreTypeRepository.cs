using Checkpoint2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint2.Core.Services
{
    public class IChoreTypeRepository
    {
        // create
        ChoreType Add(ChoreType newChoreType);
        // read
        ChoreType Get(int id);
        // update
        ChoreType Update(ChoreType choreType);
        // delete
        void Remove(ChoreType choreType);
        // list
        IEnumerable<ChoreType> GetAll();
    }
}

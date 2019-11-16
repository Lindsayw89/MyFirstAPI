using Checkpoint2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint2.Core.Services
{
    public class IChoreTypeService
    {

        ChoreType Add(ChoreType ChoreType);
        ChoreType Get(int id);
        IEnumerable<ChoreType> GetAll();
        void Remove(ChoreType ChoreType);
        ChoreType Update(ChoreType updatedChoreType);
    }
}

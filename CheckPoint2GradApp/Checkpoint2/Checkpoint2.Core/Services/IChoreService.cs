using Checkpoint2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint2.Core.Services
{
   public class IChoreService
    {

        Chore Add(Chore Chore);
        Chore Get(int id);
        IEnumerable<Chore> GetAll();
        void Remove(Chore Chore);
        Chore Update(Chore updatedChore);
    }
}

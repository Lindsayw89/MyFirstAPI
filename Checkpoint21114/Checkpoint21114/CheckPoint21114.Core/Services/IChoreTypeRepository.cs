using CheckPoint21114.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint21114.Core.Services
{
    public interface IChoreTypeRepository
    {
   
        // read
        ChoreType Get(int id);
      
        // list
        IEnumerable<ChoreType> GetAll();
    }
}

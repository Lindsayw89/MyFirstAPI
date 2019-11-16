using CheckPoint21114.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint21114.Core.Services
{
    public interface IChoreTypeService
    {
        ChoreType Get(int id);
        IEnumerable<ChoreType> GetAll(); 
      
    }
}

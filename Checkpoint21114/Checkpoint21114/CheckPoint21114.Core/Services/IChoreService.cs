using CheckPoint21114.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint21114.Core.Services
{
    public interface IChoreService
    {
        Chore Add(Chore Chore);
        Chore Get(int id);
        IEnumerable<Chore> GetAll();
        void Remove(Chore Chore);
        Chore Update(Chore updatedChore);
    }
}

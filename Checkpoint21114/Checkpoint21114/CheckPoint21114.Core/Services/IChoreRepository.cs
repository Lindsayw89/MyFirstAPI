using CheckPoint21114.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint21114.Core.Services
{
    public interface IChoreRepository
    {
        // create
        Chore Add(Chore todo);
        // read
        Chore Get(int id);
        // update
        Chore Update(Chore chore);
        // delete
        void Remove(Chore chore);
        // list
        IEnumerable<Chore> GetAll();
    }
}

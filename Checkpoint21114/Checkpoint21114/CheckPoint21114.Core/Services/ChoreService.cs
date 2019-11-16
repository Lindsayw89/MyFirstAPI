using CheckPoint21114.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint21114.Core.Services
{
    public class ChoreService : IChoreService
    {

        private readonly IChoreRepository _choreRepo;
        

        public ChoreService(IChoreRepository choreRepo)
        {
            _choreRepo = choreRepo;
            
        }

        public Chore Add(Chore Chore)
        {

            _choreRepo.Add(Chore);
            return Chore;
        }

        public Chore Get(int id)
        {
            // TODO: return the specified Activity using Find()
            return _choreRepo.Get(id);
        }

        public IEnumerable<Chore> GetAll()
        {
            // TODO: return all Activitys using ToList()
            return _choreRepo.GetAll();
        }

        public Chore Update(Chore updatedChore)
        {
            // update the todo and save
            var Chore = _choreRepo.Update(updatedChore);
            return Chore;
        }

        public void Remove(Chore Chore)
        {
            // TODO: remove the Activity
            _choreRepo.Remove(Chore);
        }
    }
}

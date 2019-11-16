using Checkpoint2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint2.Core.Services
{
    public class ChoreService : IChoreService
    {

        private IChoreRepository _choreRepo;
        private IChoreTypeRepository _choreTypeRepo;

        public ChoreService(IChoreRepository choreRepo, IChoreTypeRepository choreTypeRepo)
        {
            _choreRepo = choreRepo;
            _choreTypeRepo = choreTypeRepo;
        }

        public Chore Add(Chore Chore)
        {
            // retrieve the ActivityType so we can check
            var choreType = _choreTypeRepo.Get(Chore.ChoreTypeId);
    
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

        public Chore Update(Chore updatedActivity)
        {
            // update the todo and save
            var Activity = _choreRepo.Update(updatedActivity);
            return Activity;
        }

        public void Remove(Chore Activity)
        {
            // TODO: remove the Activity
            _choreRepo.Remove(Activity);
        }



    }
}

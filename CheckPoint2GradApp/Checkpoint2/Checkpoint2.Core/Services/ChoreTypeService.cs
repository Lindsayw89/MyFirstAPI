using Checkpoint2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint2.Core.Services
{
    public class ChoreTypeService : IChoreTypeService
    {

        private IChoreTypeRepository _choreTypeRepo;

        public ChoreTypeService(IChoreTypeRepository ChoreTypeRepo)
        {
            _choreTypeRepo = ChoreTypeRepo;
        }

        public ChoreType Add(ChoreType ChoreType)
        {
            // TODO: implement add
            _choreTypeRepo.Add(ChoreType);
            return ChoreType;
        }

        public ChoreType Get(int id)
        {
            // TODO: return the specified ActivityType using Find()
            return _choreTypeRepo.Get(id);
        }

        public IEnumerable<ChoreType> GetAll()
        {
            // TODO: return all ActivityTypes using ToList()
            return _choreTypeRepo.GetAll();
        }

        public ChoreType Update(ChoreType updatedChoreType)
        {
            // update the todo and save
            var ChoreType = _choreTypeRepo.Update(updatedChoreType);
            return ChoreType;
        }

        public void Remove(ChoreType ChoreType)
        {
            // TODO: remove the ActivityType
            _choreTypeRepo.Remove(ChoreType);
        }
    }
}

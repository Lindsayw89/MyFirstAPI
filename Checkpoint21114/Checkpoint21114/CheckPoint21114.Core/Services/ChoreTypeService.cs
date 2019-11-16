using CheckPoint21114.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint21114.Core.Services
{
    public class ChoreTypeService : IChoreTypeService
    {

        private IChoreTypeRepository _choreTypeRepo;

        public ChoreTypeService(IChoreTypeRepository ChoreTypeRepo)
        {
            _choreTypeRepo = ChoreTypeRepo;
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

   

    }
}

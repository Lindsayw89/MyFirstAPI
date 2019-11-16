using CheckPoint21114.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CheckPoint21114.Core.Services;

namespace CheckPoint21114.Infrastructure.Data
{
   public class ChoreTypeRepository: IChoreTypeRepository
    {
        private readonly AppDbContext _dbContext;
        public ChoreTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

  
        public ChoreType Get(int id)
        {

            return _dbContext.ChoreTypes
                .FirstOrDefault(a => a.Id == id);
        }
  
        public IEnumerable<ChoreType> GetAll()
        {
            return _dbContext.ChoreTypes.ToList();
        }

    }
}

using CheckPoint21114.Core.Models;
using CheckPoint21114.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CheckPoint21114.Infrastructure.Data
{
    public class ChoreRepository : IChoreRepository
    {
        private readonly AppDbContext _dbContext;
        public ChoreRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Chore Add(Chore newChore)
        {
            _dbContext.Chores.Add(newChore);
            _dbContext.SaveChanges();
            return newChore;
        }
        public Chore Get(int id)
        {

            return _dbContext.Chores
                .FirstOrDefault(chore => chore.Id == id);
        }
        public Chore Update(Chore updatedChore)
        {
            var currentChore = this.Get(updatedChore.Id);
            if (currentChore == null) return null;
            _dbContext.Entry(updatedChore).CurrentValues.SetValues(updatedChore);
            _dbContext.SaveChanges();
            return currentChore;
        }
        public IEnumerable<Chore> GetAll()
        {
            return _dbContext.Chores.ToList();
        }
        public void Remove(Chore chore)
        {
            _dbContext.Chores.Remove(chore);
            _dbContext.SaveChanges();
        }
    }
}

using CheckPoint21114.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint21114.ApiModels
{
    public class ChoreModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ChoreTypeId { get; set; }
        public DateTime Deadline { get; set; }
        public int AssignmentId { get; set; }
        public ICollection<Assignment> assignments;
    }
}

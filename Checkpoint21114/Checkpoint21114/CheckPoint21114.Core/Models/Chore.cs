using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint21114.Core.Models
{
    public class Chore
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int AssignmentId { get; set; }
    }
}

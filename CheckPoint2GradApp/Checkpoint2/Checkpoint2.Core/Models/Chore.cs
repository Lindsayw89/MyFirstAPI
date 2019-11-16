using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint2.Core.Models
{
    public class Chore
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ChoreTypeId { get; set; }
        public DateTime Deadline { get; set; }
        public int assignmentId { get; set; }
    }



    }



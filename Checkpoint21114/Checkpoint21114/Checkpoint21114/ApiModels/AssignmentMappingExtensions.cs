using CheckPoint21114.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint21114.ApiModels
{
    public static class AssignmentMappingExtensions
    {
        public static AssignmentModel ToApiModel(this Assignment assignment)
        {
            return new AssignmentModel
            {
                ChoreTypeIds = assignment.ChoreTypeId,
                ChoreId = assignment.ChoreId,

            };
        }

        public static Assignment ToDomainModel(this AssignmentModel assignmentModel)
        {
            return new Assignment
            {
                ChoreTypeId = assignmentModel.ChoreTypeIds,
                ChoreId = assignmentModel.ChoreId,



                // TODO: fill in property mappings
               
            };
        }

        public static IEnumerable<AssignmentModel> ToApiModels(this IEnumerable<Assignment> assignments)
        {
            return assignments.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Assignment> ToDomainModels(this IEnumerable<AssignmentModel> assignmentModels)
        {
            return assignmentModels.Select(a => a.ToDomainModel());
        }
    }
}

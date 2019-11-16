using Checkpoint2.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint2.ApiModels
{
    public static class ChoreMappingExtensions
    {

        public static ChoreModel ToApiModel(this Chore chore)
        {
            return new ChoreModel
            {
                Id = chore.Id,
                Title = chore.Title,
                Description = chore.Description,
                ChoreTypeId = chore.ChoreTypeId,
                Deadline = chore.Deadline,
                AssignmentId = chore.AssignmentId,

            };
        }

        public static Chore ToDomainModel(this ChoreModel choreModel)
        {
            return new Chore
            {
                Id = choreModel.Id,
                Title = choreModel.Title,
                Description = choreModel.Description,
                ChoreTypeId = choreModel.ChoreTypeId,
                Deadline = choreModel.Deadline,
                AssignmentId = choreModel.AssignmentId,

            };
        }

        public static IEnumerable<ChoreModel> ToApiModels(this IEnumerable<Chore> chores)
        {
            return chores.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Chore> ToDomainModels(this IEnumerable<ChoreModel> choreModels)
        {
            return choreModels.Select(a => a.ToDomainModel());
        }

    }
}

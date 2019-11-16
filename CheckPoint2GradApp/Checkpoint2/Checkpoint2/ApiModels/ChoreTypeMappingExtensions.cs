using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint2.ApiModels
{
    public static class ChoreTypeMappingExtensions
    {


        public static ChoreTypeModel ToApiModel(this ChoreType choreType)
        {
            return new ChoreTypeModel
            {
                Id = choreType.Id,
                Title = choreType.Title,
         
            };
        }

        public static ChoreTypeModel ToDomainModel(this ChoreTypeModel choreTypeModel)
        {
            return new ChoreType
            {
                Id = choreTypeModel.Id,
                Title = choreTypeModel.Title,
              

            };
        }

        public static IEnumerable<ChoreTypeModel> ToApiModels(this IEnumerable<ChoreType> choreTypes)
        {
            return choreTypes.Select(a => a.ToApiModel());
        }

        public static IEnumerable<ChoreType> ToDomainModels(this IEnumerable<ChoreTypeModel> choreTypeModels)
        {
            return choreTypeModels.Select(a => a.ToDomainModel());
        }
    }
}

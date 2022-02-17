using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domain.Services.Validations
{
    public class EntityWithStatusValidator : IEntityStatusValidator
    {
        public const string MissingEntityErrorMessage = "Entity does not exist.";
        public bool Validate(Status status)
        {
            if(status == Status.ACTIVE)
            {
                return true;
            }
            throw new Exception(MissingEntityErrorMessage);
        }

        public bool Validate(EntityWithStatus entityWithStatus)
        {
            if(entityWithStatus.Status == Status.ACTIVE)
            {
                return true;
            }
            throw new Exception(MissingEntityErrorMessage);
        }
    }
}

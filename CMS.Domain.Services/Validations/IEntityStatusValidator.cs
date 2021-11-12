using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domain.Services.Validations
{
    public interface IEntityStatusValidator
    {
        bool Validate(Status status);

        bool Validate(EntityWithStatus entityWithStatus);
    }
}

using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record ProductCandidateDto
    (
        Guid Id, 
        string Name,
        string Code,
        string Description,
        string Image,
        DateTime? ExpireDate,
        decimal Price,
        State State
    );
}

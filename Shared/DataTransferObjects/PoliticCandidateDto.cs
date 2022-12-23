using Entities.Enums;

namespace Shared.DataTransferObjects
{
    public record PoliticCandidateDto
    (
        Guid Id,
        string Code,
        string Description,
        string Image,
        string PoliticDocInfo,
        string PartyName,
        State State
    );
}

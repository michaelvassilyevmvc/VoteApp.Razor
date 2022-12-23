namespace Shared.DataTransferObjects
{
    public record VoteDto
    (
        Guid UserId,
        Guid CandidateId,
        DateTime VoteDate,
        DateTime Created
    );
}

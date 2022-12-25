namespace Shared.DataTransferObjects
{
    public record VoteDto
    {
        public Guid UserId { get; set; }
        public Guid CandidateId { get; set; }
        public DateTime VoteDate { get; set; }
        public DateTime Create { get; set; }
    }
}

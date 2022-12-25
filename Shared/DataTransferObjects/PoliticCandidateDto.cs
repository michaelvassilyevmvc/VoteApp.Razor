using Entities.Enums;

namespace Shared.DataTransferObjects
{
    public record PoliticCandidateDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string PoliticDocInfo { get; set; }
        public string PartyName { get; set; }
        public State State { get; set; }
    }
}

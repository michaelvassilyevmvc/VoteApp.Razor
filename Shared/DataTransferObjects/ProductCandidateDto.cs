using Entities.Enums;

namespace Shared.DataTransferObjects
{
    public record ProductCandidateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime? ExpireDate { get; set; }
        public decimal Price { get; set; }
        public State State { get; set; }
    }
}

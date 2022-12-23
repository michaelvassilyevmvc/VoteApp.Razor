using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class VoteConfiguration : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> builder)
        {
            builder.HasKey(x => new
            {
                UserId = x.UserId,
                CandidateId = x.CandidateId
            });

            builder.HasData(
                new Vote
                {
                    UserId = new Guid("7D42621C-3756-4A82-BF2B-69FCFCA6E0F2"),
                    CandidateId = new Guid("D02C6BFB-FCE6-4DBF-94EC-57991D2DFA4F")
                }
            );
        }
    }
}

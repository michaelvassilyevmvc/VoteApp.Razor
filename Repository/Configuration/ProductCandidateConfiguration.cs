using Entities.Enums;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class ProductCandidateConfiguration : IEntityTypeConfiguration<ProductCandidate>
    {
        public void Configure(EntityTypeBuilder<ProductCandidate> builder)
        {
            builder.HasData(
                new ProductCandidate
                {
                    Id = new Guid("7A7CA13C-B54D-438B-AC64-BF0AFB5F27AB"),
                    Code = "1223654",
                    Description = "Игровая приставка последнего поколения",
                    Name = "xBox",
                    Price = 1200,
                    State = State.Active,
                    Image = "https://webimg.secondhandapp.com/1.1/5ee090244cda6c0045831abe"
                },
                new ProductCandidate
                {
                    Id = new Guid("D02C6BFB-FCE6-4DBF-94EC-57991D2DFA4F"),
                    Code = "773332",
                    Description = "Революционная платформа с множеством эксклюзивов",
                    Name = "PS5",
                    Price = 2000,
                    State = State.Active,
                    Image = "https://frankfurt.apollo.olxcdn.com/v1/files/la9yesqjseih3-KZ/image;s=1280x960"
                }
            );
        }
    }
}

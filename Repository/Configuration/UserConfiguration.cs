using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = new Guid("7D42621C-3756-4A82-BF2B-69FCFCA6E0F2"),
                    LName = "Васильев",
                    FName = "Михаил",
                    Login = "rebusmv",
                    Image = "https://media.istockphoto.com/id/918169872/photo/close-up-view-of-a-siberian-tiger.jpg?s=1024x1024&w=is&k=20&c=kDcPgGgEuSPt7_HNNlHqXEf4g86-ZIF5NLuobfm9NYg=",
                    DoB = new DateTime(1986, 11, 5),
                    Password = "q2w3e4r5"
                },
                new User
                {
                    Id = new Guid("CB06552D-4779-487D-A3EF-774406E705F9"),
                    LName = "Иванов",
                    FName = "Семен",
                    Login = "ivanov",
                    DoB = new DateTime(2000, 3, 11),
                    Password = "123"
                }
                );
        }
    }
}

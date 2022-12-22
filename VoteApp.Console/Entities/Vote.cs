using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using VoteApp.Console.Attributes;

namespace VoteApp.Console.Entities
{
    //[Index(nameof(UserId), nameof(CandidateId), IsUnique = true)]
    [Table("votes")]
    [CustomName("Голосование")]
    public class Vote
    {
        public Guid UserId { get; set; }
        public Guid CandidateId { get; set; }

        [JsonIgnore]
        public User User { get; set; }
        [JsonIgnore]
        public CandidateBase Candidate { get; set; }

        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime VoteDate { get; set; } = DateTime.UtcNow;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; } = DateTime.UtcNow;


    }
}

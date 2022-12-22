using System.ComponentModel.DataAnnotations.Schema;
using VoteApp.Console.Attributes;

namespace VoteApp.Console.Entities
{
    [Table("politics")]
    [CustomName("Политика")]
    public class PoliticCandidate : CandidateBase
    {
        public string PoliticDocInfo { get; set; }
        public string PartyName { get; set; }

    }
}

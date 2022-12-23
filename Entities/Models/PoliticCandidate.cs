using Entities.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("politics")]
    [CustomName("Политика")]
    public class PoliticCandidate : CandidateBase
    {
        public string PoliticDocInfo { get; set; }
        public string PartyName { get; set; }

    }
}

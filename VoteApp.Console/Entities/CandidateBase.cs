using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoteApp.Console.Entities
{
    [Table("candidates", Schema = "dbo")]
    public abstract class CandidateBase
    {
        [Key]
        [DisplayName("Candidate Id")]
        public Guid Id { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [DisplayName("Изображение")]
        public string Image { get; set; }

        public State State { get; set; }


    }
}

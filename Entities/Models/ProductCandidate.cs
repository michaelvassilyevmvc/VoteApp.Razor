using Entities.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("products")]
    [CustomName("Продукты")]
    public class ProductCandidate : CandidateBase
    {
        [Display(Name = "Название")]
        [MaxLength(120)]
        public string Name { get; set; }
        [Display(Name = "Код")]
        [MaxLength(12)]
        public string Code { get; set; }
        [Display(Name = "Истечения срока годности")]
        public DateTime? ExpireDate { get; set; }
        [Display(Name = "Цена")]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Price { get; set; }

    }
}

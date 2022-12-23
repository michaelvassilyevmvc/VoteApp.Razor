using Entities.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("users")]
    [CustomName("Пользователь")]
    public class User
    {
        [Key]
        [Required]
        [DisplayName("User Id")]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Имя")]
        [MaxLength(150)]
        public string FName { get; set; }
        [Required]
        [Display(Name = "Фамилия")]
        [MaxLength(150)]
        public string LName { get; set; }

        [Required]
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        public string? Image { get; set; }

        [Required]
        [DisplayName("Логин")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}

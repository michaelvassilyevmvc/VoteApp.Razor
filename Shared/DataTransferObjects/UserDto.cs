namespace Shared.DataTransferObjects
{
    public record UserDto
    {
        public Guid Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}

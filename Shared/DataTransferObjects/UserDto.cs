namespace Shared.DataTransferObjects
{
    public record UserDto(Guid Id,
        string FName,
        string LName,
        DateTime DateOfBirth,
        string Login,
        string Password);
}

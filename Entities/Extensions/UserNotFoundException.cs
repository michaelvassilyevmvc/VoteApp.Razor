namespace Entities.Extensions
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(Guid userId) : base($"Пользователь с id: {userId} не существует в базе данных") { }
    }
}

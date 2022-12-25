namespace Entities.Extensions
{
    public class VoteNotFoundException : NotFoundException
    {
        public VoteNotFoundException(Guid userId, Guid candidateId) : base($"Голосование для пользователя с id: {userId} и объекта выбора с id: {candidateId} не существует в базе данных") { }
    }
}

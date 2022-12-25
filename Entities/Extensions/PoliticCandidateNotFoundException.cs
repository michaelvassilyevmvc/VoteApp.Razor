namespace Entities.Extensions
{
    public class PoliticCandidateNotFoundException : NotFoundException
    {
        public PoliticCandidateNotFoundException(Guid politicCandidateId) : base($"Политик с id: {politicCandidateId} отсутствует в базе данных")
        {

        }
    }
}

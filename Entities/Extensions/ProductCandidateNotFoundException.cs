namespace Entities.Extensions
{
    public class ProductCandidateNotFoundException : NotFoundException
    {
        public ProductCandidateNotFoundException(Guid productCandidateId) : base($"Продукт с id = {productCandidateId} отсутствует в базе данных") { }
    }
}

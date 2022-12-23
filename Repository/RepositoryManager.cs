using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<UserRepository> _userRepository;
        private readonly Lazy<VoteRepository> _voteRepository;
        private readonly Lazy<ProductCandidateRepository> _productCandidateRepository;
        private readonly Lazy<PoliticCandidateRepository> _politicCandidateRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _userRepository = new Lazy<UserRepository>(() => new UserRepository(repositoryContext));
            _voteRepository = new Lazy<VoteRepository>(() => new VoteRepository(repositoryContext));
            _politicCandidateRepository = new Lazy<PoliticCandidateRepository>(() => new PoliticCandidateRepository(repositoryContext));
            _productCandidateRepository = new Lazy<ProductCandidateRepository>(() => new ProductCandidateRepository(repositoryContext));
        }

        public IPoliticCandidateRepository PoliticCandidate => _politicCandidateRepository.Value;

        public IProductCandidateRepository ProductCandidate => _productCandidateRepository.Value;

        public IVoteRepository Vote => _voteRepository.Value;

        public IUserRepository User => _userRepository.Value;

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}

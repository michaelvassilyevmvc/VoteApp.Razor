using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoteApp.Console.Entities;

namespace VoteApp.Console.Models
{
    public class CandidateFactory
    {
        public CandidateBase CreateCandidate(string type)
        {
            return type switch
            {
                "Politic" => new PoliticCandidate(),
                "Product" => new ProductCandidate(),
                _ => throw new NotSupportedException(),
            };
        }
    }
}

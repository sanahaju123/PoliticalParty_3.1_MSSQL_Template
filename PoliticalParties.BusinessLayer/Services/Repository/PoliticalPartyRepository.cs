using Microsoft.EntityFrameworkCore;
using PoliticalParties.BusinessLayer.ViewModels;
using PoliticalParties.DataLayer;
using PoliticalParties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliticalParties.BusinessLayer.Services.Repository
{
    public class PoliticalPartyRepository : IPoliticalPartyRepository
    {
        private readonly PoliticalPartiesDbContext _politicalPartiesDbContext;
        public PoliticalPartyRepository(PoliticalPartiesDbContext politicalPartiesDbContext)
        {
            _politicalPartiesDbContext = politicalPartiesDbContext;
        }

        public async Task<PoliticalParty> GetById(long politicalPartyId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PoliticalParty>> GetByPartyName(string politicalPartyName)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PoliticalParty>> GetByFounderName(string politicalPartyFounderName)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PoliticalParty>> GetAll()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<PoliticalParty> Create(PoliticalParty politicalParty)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<PoliticalParty> Update(RegisterPoliticalPartyViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<PoliticalParty> Delete(RegisterPoliticalPartyViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}

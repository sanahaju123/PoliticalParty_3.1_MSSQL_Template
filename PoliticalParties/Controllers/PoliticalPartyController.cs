using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoliticalParties.BusinessLayer.Interfaces;
using PoliticalParties.BusinessLayer.ViewModels;
using PoliticalParties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliticalParties.Controllers
{
    [ApiController]
    public class PoliticalPartyController : ControllerBase
    {
        private readonly IPoliticalPartyServices _politicalPartyServices;

        public PoliticalPartyController(IPoliticalPartyServices politicalPartyServices)
        {
            _politicalPartyServices = politicalPartyServices;
        }

        #region PoliticalPartyRegion
        /// <summary>
        /// Create a new Political Party
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("parties")]
        [EnableCors("AllowAll")]
        public async Task<IActionResult> Register([FromBody] RegisterPoliticalPartyViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a existing Political Party
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("parties/{id}")]
        [EnableCors("AllowAll")]
        public async Task<IActionResult> UpdatePoliticalParty(long id,[FromBody] RegisterPoliticalPartyViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a existing Political Party
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("parties/{id}")]
        [EnableCors("AllowAll")]
        public async Task<IActionResult> DeletePoliticalParty(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Political Party by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("parties/{id}")]
        [EnableCors("AllowAll")]
        public async Task<IActionResult> GetPoliticalPartyById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Political Party by Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("parties/searchParty")]
        [EnableCors("AllowAll")]
        public async Task<IActionResult> GetPoliticalPartyByName([FromQuery] string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Political Party by Founder Name
        /// </summary>
        /// <param name="founderName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("parties/search")]
        [EnableCors("AllowAll")]
        public async Task<IActionResult> GetPoliticalPartyByFounderName([FromQuery] string founderName)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// List All political Parties
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("parties")]
        [EnableCors("AllowAll")]
        public async Task<IEnumerable<PoliticalParty>> ListAllPoliticalParties()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        #endregion
    }
}

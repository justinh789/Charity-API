using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityApp.Core;
using CharityApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Routing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CharityApp.Web.Service.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrganizationsController : CharityAppBaseController
    {
        private readonly ICharityService _charityService;


        #region ctor
        public OrganizationsController(ICharityService charityService)
        {
            _charityService = charityService;
        }
        #endregion


        #region HttpGet
        //[HttpGet("Get")]
        //public async Task<IEnumerable<Organization>> GetAllAsync()
        //{
        //    return await _charityService.GetAllAsync();

        //}

        [HttpGet("{id}")]
        public async Task<ActionResult<Organization>> Get(Guid id)
        {
            var charity = await Task.FromResult(_charityService.GetById(id));

            if (charity == null)
                return NotFound();

            return charity;
        }
        #endregion

        #region HttpDelete
        [HttpDelete("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            _charityService.SoftDelete(id);


            return Ok();
        }
        #endregion

        #region HttpPost
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Post([FromBody]string value)
        {

        }
        #endregion

        #region HttpPut
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

        }
        #endregion




      

      
      
    }
}

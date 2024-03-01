using CharityApp.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using CharityApp.Core.Domain;
using CharityApp.Services.Interfaces;
using CharityApp.Services;

namespace CharityApp.Web.Service.Controllers
{
    [Route("api/Categories")]
    [ApiController]
    public class CategoryController : CharityAppBaseController
    {
        private readonly ICharityService _charityService;
        
        
        public CategoryController(ICharityService charityService)
        {
            _charityService = charityService;
        }

        //categories #all categories
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _charityService.GetCategories();
        }

        //Categories/2/subcategory #all subcategories belonging to a particular category (2)
        [HttpGet("/{categoryId}/subcategory")]
        public IEnumerable<Subcategory> GetSubCategory(int categoryId)
        {
            return _charityService.GetSubcategories(categoryId);
        }
    }
}

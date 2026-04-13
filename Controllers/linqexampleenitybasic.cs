using linqenityframework.NorthWind_Connect;
using linqenityframework.NorthWindDb_Connect;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace linqenityframework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class linqexampleenitybasic : ControllerBase
    {
        NorthwindContext _NorthwindContext;
        NorthwindDbContext _northwindDbContext;

        public linqexampleenitybasic(NorthwindContext northwindContext, NorthwindDbContext northwindDbContext)
        {
            _NorthwindContext = northwindContext;
            _northwindDbContext = northwindDbContext;
        }

        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult GetProducts()
        {
           // var result = from abc in _NorthwindContext.Employees select abc;-- it will work
            var jsonSettings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };

            //It converts your data to jsonformat
            var convertedData = JsonConvert.SerializeObject(result, jsonSettings);
            return StatusCode(StatusCodes.Status200OK, convertedData);

            //return StatusCode(StatusCodes.Status200OK,result);
        }
         
    }
}

using Newtonsoft.Json;
using Student_Details_API.Helper;
using Student_Details_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Student_Details_API.Controllers
{
    [Route("[controller]")]
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("getjson")]
        public async Task<IHttpActionResult> GetStudentJson()
        {
            var data = ApiHelper.PopulateObject();
            var convertedData = JsonConvert.SerializeObject(data);

            var httpResp = Request.CreateResponse(System.Net.HttpStatusCode.OK, convertedData);
            httpResp.Content = new StringContent(convertedData, System.Text.Encoding.UTF8, "application/json");
            httpResp.Headers.Add("Access-Control-Allow-Origin", "*");
            return await Task.FromResult(ResponseMessage(httpResp)); ;
        }
    }
}

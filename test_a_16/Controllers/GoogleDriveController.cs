using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using test_a_16;

namespace test_a_16.Controllers
{
    public class GoogleDriveController : ApiController
    {
        // GET api/googledrive
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/googledrive/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/googledrive
        public void Post([FromBody]string value)
        {
        }

        // PUT api/googledrive/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/googledrive/5
        public void Delete(int id)
        {
        }
    }
}
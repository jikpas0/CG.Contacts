using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CG.Contacts.Controllers
{
    public class ContactSyncController : ApiController
    {
        // GET: api/ContactSync
        public IEnumerable<string> Get()
        {
            return new string[] {  };
        }

        // GET: api/ContactSync/5
        public string Get(int id)
        {
            return "";
        }

        // POST: api/ContactSync
        public string Post([FromBody]string value)
        {
            return "";
        }
    }
}

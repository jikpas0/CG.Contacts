using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mod = CG.Contacts.Models;
using System.Runtime.Caching;

namespace CG.Contacts.Controllers
{
    public class ContactSyncController : ApiController
    {
        private ObjectCache cache = MemoryCache.Default;
        private CacheItemPolicy policy = new CacheItemPolicy();

        // GET: api/ContactSync
        public IEnumerable<string> Get()
        {
            List<mod.Contacts> cachedValue = (List<mod.Contacts>)cache.Get("contactsValue");
            return new string[] {  };
        }

        // GET: api/ContactSync/5
        public string Get(int id)
        {
            return "";
        }

        // POST: api/ContactSync
        public string Post(IEnumerable<mod.Contacts> value)
        {
            cache.Set("contactsValue", value, policy);
            return "";
        }
    }
}

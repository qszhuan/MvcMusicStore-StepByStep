using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore_StepByStep.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public string Index()
        {
            return "Hello from store.Index()";
        }

        public string Browse(string genre)
        {
            var message = HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);
            return message;
        }

        public string Details()
        {
            return "Hello from store.Details()";
        }

    }
}

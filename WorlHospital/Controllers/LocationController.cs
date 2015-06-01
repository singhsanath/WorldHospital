using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorlHospital.Controllers
{
    public class LocationController : Controller
    {
        //
        // GET: /Location/

        public JsonResult Country()
        {
           
            return Json( "countries" );
        }
        public JsonResult states(string country)
        {
            return Json( "states object" );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorlHospital.Models;
namespace WorlHospital.Controllers
{
    public class LocationController : Controller
    {

        patientRegLogContext database = new patientRegLogContext( );
       
        //
        // GET: /Location/

        public JsonResult Country()
        {
           
            return Json( "countries" );
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult states(string country)
        {
            var state = database.Location.Where(b=>b.country==country);
            
            return Json( state );
        }
    }
}

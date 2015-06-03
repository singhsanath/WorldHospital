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
        public JsonResult states(Locations country)
        {
            var state = database.Location.Where(b=>b.country==country.country);
            //country.country = "India";
            //country.state = "AP";
            //country.StateID = "123";
            
            return Json(country  );
        }
    }
}

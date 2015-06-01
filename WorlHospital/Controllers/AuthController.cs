using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorlHospital.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/

        [AllowAnonymous]
        [HttpGet]
       public ActionResult Login()
        {
            return View( );

        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Registration()
       {
           return View( );
       }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult Registration(string Client_Data)
        {
            return Json( Client_Data );
        }

        public JsonRequestBehavior Login( string Client_login )
        {
            return JsonRequestBehavior.AllowGet;
        }


    }
}

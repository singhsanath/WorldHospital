using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorlHospital.Models;

namespace WorlHospital.Controllers
{
    public class AuthController : Controller
    {
        public static int PID = 0;
        patientRegLogContext database = new patientRegLogContext( );
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
        public JsonResult Registration( PatientRegistration PatientReg )
        {
            PID++;
            PatientReg.PID=PID.ToString();
            PatientReg.Password="123456aA";
            database.PatientDetails.Add( PatientReg );
            database.SaveChanges( );

            return Json( PatientReg );
        }

        public JsonRequestBehavior Login( string Client_login )
        {
            return JsonRequestBehavior.AllowGet;
        }


    }
}

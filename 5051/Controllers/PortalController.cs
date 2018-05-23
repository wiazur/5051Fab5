using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5051.Controllers
{
    public class PortalController : Controller
    {
        /// <summary>
        /// The Login in page for the Portal, shows all the Students
        /// </summary>
        /// <returns></returns>
        // GET: Portal
        public ActionResult Login()
        {
            return View();
        }


        /// <summary>
        /// Student default page after login
        /// </summary>
        /// <returns></returns>
        // GET: Portal
        public ActionResult FirstIndex()
        {
            return View();
        }
        
        /// <summary>
        /// Index Page
        /// </summary>
        /// <returns></returns>
        // GET: Portal
        public ActionResult IndexNinaCopy()
        {
            return View();
        }

        /// <summary>
        /// Student's Avatar page
        /// </summary>
        /// <returns></returns>
        // GET: Portal
        public ActionResult Avatar()
        {
            return View();
        }
        
          /// <summary>
        ///Market Page
        /// </summary>
        /// <returns></returns>
        // GET: Portal
        public ActionResult Market()
        {
            return View();
        }

        /// <summary>
        ///Market Page
        /// </summary>
        /// <returns></returns>
        // GET: Portal
        public ActionResult Accomplishments()
        {
            return View();
        }

        /// <summary>
        /// The Group's House information
        /// </summary>
        /// <returns></returns>
        // GET: Portal
        public ActionResult Group()
        {
            return View();
        }

        /// <summary>
        ///  My House
        /// </summary>
        /// <returns></returns>
        // GET: Portal
        public ActionResult House()
        {
            return View();
        }

        /// <summary>
        ///  My Settings
        /// </summary>
        /// <returns></returns>
        // GET: Portal
        public ActionResult Settings()
        {
            return View();
        }

        /// <summary>
        /// My Attendance Reports
        /// </summary>
        /// <returns></returns>
        // GET: Portal
        public ActionResult Report()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace ArtWeb.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactResult()
        {
            return PartialView();
        }

        public ActionResult ContactAjax()
        {
            var contact = new Models.Contact();
            contact.Message = Resources.Home.Contact.message;
            contact.Name = Resources.Home.Contact.textboxName;
            contact.Email = Resources.Home.Contact.textboxEmail;
            return PartialView(contact);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ContactAjax(Models.Contact task)
        {
            if (ModelState.IsValid)
            {
                var data1 = task.Name + ", " + task.Email;

                var bRet = task.SendEmail();
                TempData["Status"] = "emailSent";

                return PartialView("contactResult", task);
            }
            else
            {
                TempData["Status"] = "Message err from controller";
                return PartialView("ContactAjax", task);
                //return PartialView("contactResult", task);
            }
        }

    }
}
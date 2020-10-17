using System;
using System.Collections.Generic;
using System.Linq;
using www.exclusivepainters.co.nz.Models;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Threading.Tasks;

namespace www.exclusivepainters.co.nz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

      
        public  ActionResult Contact(ContactForm model)
        {
            if (ModelState.IsValid)
            {

                var mail = new MailMessage();
                mail.To.Add(new MailAddress(model.SenderEmail, "pankajpuri016@gmail.com"));
                mail.Subject = "Your Email Subject";
                mail.Body = string.Format("<p>Email From: {0} ({1})</p><p>Mobile: {2}</p><p>Message:</p><p>{3}</p>", model.SenderName, model.SenderEmail,model.Mobile, model.Message);
                mail.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("pankajpuri016@gmail.com", "babybird");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    ModelState.Clear();
                    

                }
             
        }
            return View();
        }

    }
}
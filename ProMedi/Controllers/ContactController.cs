using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProMedi.DAL;
using ProMedi.ViewModels;
using System.Net.Mail;
using ProMedi.Models;
using System.Net;

namespace ProMedi.Controllers
{
    public class ContactController : BaseController
    {
        // GET: Contact
        public ActionResult Contact()   
        {
            VmContact model = new VmContact
            {
                Contacts = _context.Contacts.ToList(),
                Setting = _context.Settings.FirstOrDefault()
            };

            return View(model);
        }

        public JsonResult Message(string name, string email, string subject, string number, string message)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(message))
            {
                Response.StatusCode = 406;
                return Json("Ad,E-Poçt və Mesaj bölməsi boş olmamalıdır .", JsonRequestBehavior.AllowGet);
            }

            var body = "<ul><li>Ad : {0}</li><li>E-Poçt : {1}</li><li>Əlaqə nömrəsi : {2}</li><li>Mesaj : {3}</li></ul><p>{4}</p>";
            var MailMessage = new MailMessage();
            MailMessage.To.Add(new MailAddress("elvinem@code.edu.az"));
            MailMessage.From = new MailAddress(email);  
            MailMessage.Subject = subject;
            MailMessage.Body = string.Format(body, name, email, subject, number, message);
            MailMessage.IsBodyHtml = true;

            SmtpClient client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential
                {
                    UserName = "elvinem@code.edu.az",  
                    Password = "elvin1998"
                }
            };

            client.Send(MailMessage);


            return Json("Mesajınız uğurla göndərildi , təşəkkürlər !", JsonRequestBehavior.AllowGet);
        }
    }
}
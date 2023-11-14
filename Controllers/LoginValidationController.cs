using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using WebApplication8.Models;
using WebApplication8.Database;
using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication8.Controllers
{
    public class LoginValidationController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly AnantyaDbContext _context;

        public LoginValidationController(IWebHostEnvironment hostingEnvironment, AnantyaDbContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;

        }
        public IActionResult login(string UserName, string Password)
        {

            if (UserName == "Saurabh" && Password == "Saurabh@123")
            {
                var number = HttpContext.Session.GetInt32("Token");
                return RedirectToAction("Dashboard", "Admin", new {r= number});
            }
            else
            {
                return RedirectToAction("Admin", "Admin");
            }
        }

        public IActionResult Sendmail(Register register)
        {
            MailMessage mailMessage = new MailMessage();           
            mailMessage.From = new MailAddress("mobi.seniordeveloper@gmail.com");
            mailMessage.To.Add(register.Email);
            mailMessage.IsBodyHtml = true;            
            mailMessage.Subject = "Testing";
            Random random = new Random();
            int randomNumber = random.Next(100000, 999999);
            HttpContext.Session.SetInt32("OTP", @randomNumber);
            string body = @"<Html>
                              <body>
                                    <p> OTP :"+" "+ randomNumber + "</p></body></html>";
            mailMessage.Body = body;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            NetworkCredential networkCredential = new NetworkCredential("mobi.seniordeveloper@gmail.com", "afktcwqzdwfyqjuq");
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = networkCredential;
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);

            return RedirectToAction("EmailVarification", "Admin");
        }

        public IActionResult OTPverification(Register register, int OTP)
        {
            var number = HttpContext.Session.GetInt32("OTP");
            if (OTP == number)
            {
                _context.Register.Add(register);
                _context.SaveChanges();
                return RedirectToAction("Admin","Admin");
            }
            else
            {
                return View();
            }
        }
    }
}

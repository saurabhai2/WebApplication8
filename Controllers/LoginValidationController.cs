using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using WebApplication8.Models;
using WebApplication8.Database;
using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.AspNetCore.Http;


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
        public bool ValidateCredentials(string username, string password)
        {
            var HashPass = DatabaseSeeder.HashPassword(password); ;
            var user = _context.Register.FirstOrDefault(u => u.Username == username && u.Password == HashPass);

            return user != null; // Returns true if the user exists and credentials are valid
        }
        public IActionResult login(string UserName, string Password)
        {
            bool isAuthenticated = ValidateCredentials( UserName,  Password);
            if (isAuthenticated)
            {
                HttpContext.Session.SetString("UserName", UserName);
                var number = HttpContext.Session.GetInt32("Token");
                return RedirectToAction("Dashboard", "Admin", new {r= number});
            }
            else
            {
                return RedirectToAction("Admin", "Admin");
            }
        }

        public IActionResult AddUser(Register register) 
        {
            if (register != null)
            {
                 register.Password = DatabaseSeeder.HashPassword(register.Password);
                _context.Register.Add(register);
                _context.SaveChanges();
            }
            
            var number = HttpContext.Session.GetInt32("Token");
            return RedirectToAction("USerInfo", "Admin", new { r = number });
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
            HttpContext.Session.SetString("Username", register.Username);
            HttpContext.Session.SetString("Password", register.Password);
            HttpContext.Session.SetString("Email", register.Email);
           

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
                register.Username = HttpContext.Session.GetString("Username");
                register.Password = HttpContext.Session.GetString("Password");
                register.Email = HttpContext.Session.GetString("Email");
                _context.Register.Add(register);
                _context.SaveChanges();
                return RedirectToAction("Admin","Admin");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            var entityToDelete = _context.Register.FirstOrDefault(e => e.Id == id);

            if (entityToDelete != null)
            {
                // Remove the entity
                _context.Register.Remove(entityToDelete);

                // Save changes to delete the entity from the database
                _context.SaveChanges();
            }
            var number = HttpContext.Session.GetInt32("Token");
            return RedirectToAction("USerInfo", "Admin", new { r = number });
        }


    }
}

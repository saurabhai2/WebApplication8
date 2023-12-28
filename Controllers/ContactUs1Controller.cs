using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using System.Xml.Linq;
using MailKit;
using System.Net.Mail;
using WebApplication8.Models;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using System.Net.Mime;
using System.IO;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using RestSharp;
using System.Text;
using WebApplication8.Database;
using static Azure.Core.HttpHeader;
using System.Security.Cryptography;

namespace WebApplication8.Controllers
{
    public class ContactUs1Controller : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly AnantyaDbContext _context;
        private readonly IConfiguration _configuration;


        public ContactUs1Controller(IWebHostEnvironment hostingEnvironment, AnantyaDbContext context, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Contact(string Name, string email, string phone, string message, string url, string RefNumber, ContactForm contactForm)
        {
            var emailSettings = _configuration.GetSection("EmailSettings").Get<EmailSetting>();
            var EmailSender = emailSettings.EmailSender;
            var EmailReciver = emailSettings.EmailReciver;
            var password = emailSettings.Password;
            try
            {
                MailMessage mailMessage = new MailMessage();
                MailMessage mailMessage1 = new MailMessage();
                mailMessage.From = new MailAddress(EmailSender);
                mailMessage.To.Add(EmailReciver);
                mailMessage1.From = new MailAddress(EmailSender);
                mailMessage1.To.Add(email);

                mailMessage.IsBodyHtml = true;
                mailMessage1.IsBodyHtml = true;
                mailMessage.Subject = "User Contact From Website";
                mailMessage1.Subject = "Response From Anantya";
                string body = @"<Html>
                                    <body>
                                        <p> Name : " + Name + "</p> <br> <br>" +
                                        "<p> Email :" + email + "</p> <br> <br>" +
                                        "<p> Phone:" + phone + "</p> <br> <br>" +
                                        "<p> Message :" + message + "</p> <br> <br>" +
                                        "<p> url:" + url + "</p> <br> <br> </body></html>";
                mailMessage.Body = body;
                string htmlBody = System.IO.File.ReadAllText(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "Views","EmailTem","EmailTemplate.cshtml"));
                mailMessage1.Body = htmlBody;
               // Create LinkedResource for each image and set their Content-IDs
               //var logoImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/logo.png"));
               //logoImage.ContentId = "logoImage";
                /*  var anotherImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/panel.png"));
                  anotherImage.ContentId = "panelImage";
                  var aiImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/ai.png"));
                  aiImage.ContentId = "aiImage";
                  var featureImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/feature.png"));
                  featureImage.ContentId = "featureImage";
                  var linkdinImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/linkdin.png"));
                  linkdinImage.ContentId = "linkdinImage";
                  var instagramImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/instagram.png"));
                  instagramImage.ContentId = "instagramImage";
                  var facebookImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/facebook.png"));
                  facebookImage.ContentId = "facebookImage";
                  var websiteImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/website.png"));
                  websiteImage.ContentId = "websiteImage";

                  // Create the HTML view
                  AlternateView htmlView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);
                  //htmlView.LinkedResources.Add(logoImage);
                  htmlView.LinkedResources.Add(anotherImage);
                  htmlView.LinkedResources.Add(aiImage);
                  htmlView.LinkedResources.Add(featureImage);
                  htmlView.LinkedResources.Add(linkdinImage);
                  htmlView.LinkedResources.Add(instagramImage);
                  htmlView.LinkedResources.Add(facebookImage);
                  htmlView.LinkedResources.Add(websiteImage);

                  // Set the HTML view as the email's body
                  mailMessage1.AlternateViews.Add(htmlView);*/

                // Smtp Client 

               SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                NetworkCredential networkCredential = new NetworkCredential(EmailSender, password);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                smtpClient.Send(mailMessage1);

                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri("https://api.leadsquared.com/v2/");
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    // Replace with your LeadSquared API access token and API secret key
                    
                    httpClient.DefaultRequestHeaders.Add("accessKey", "u$rce7dad9984ce11949354bb263d4b2ccf");
                    httpClient.DefaultRequestHeaders.Add("secretKey", "b91df9ce97dfe611b5448d0efcf74586439bedf5");

                    var contactData = new
                    {
                        Name = Name,
                        email = email,
                        phone = phone,
                        url = url,
                        owner = "kalpana",






                    };
                    // Create a JSON string from your contact form data
                    string jsonContactData = Newtonsoft.Json.JsonConvert.SerializeObject(contactData);

                    // Send a POST request to create a new lead
                    var response = await httpClient.PostAsync("LeadManagement.svc/Lead.Create", new StringContent(jsonContactData, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        // Success handling
                    }
                    else
                    {
                        // Error handling
                    }
                }

                

                //   var client = new RestClient("https://api.leadsquared.com/v2/LeadManagement.svc/Lead.Create");
                //  RestRequest request = new RestRequest(Method.Post);
                //request.AddHeader("Content-Type", "application/json");
                //request.AddHeader("Authorization", "LSApiKey Your-Access-Key:Your-Secret-Key");

                // Define the data you want to send to LeadSquared
                //   var contactData = new
                // {
                //   FirstName = "John",
                // LastName = "Doe",
                //Email = "johndoe@example.com",
                // Add other fields as needed
                //   };

                //   request.AddJsonBody(contactData);

                // Execute the request
                //  var response = client.Execute(request);

                // Check the response and handle any errors or success accordingly
                //  if (response.IsSuccessful)
                //    {
                // Data was successfully inserted into LeadSquared
                //  }
                //    else
                //  {
                // Handle the error
                //  }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var contact = new ContactForm
            {
                
                Name = Name,
                Email = email,
                Phone = phone,
                Message = message,
                url = url,
                RefNumber = RefNumber,
            };

            SaveData(contact, null);

            return RedirectToAction("ContactUs", "Home"); 
        }

        private void SaveData(ContactForm? contact, PatnerwithUs? contact1)
        {
            // Common logic that both Action1 and Action2 need
            // ...

            // Save the contact object to the database using Entity Framework Core
            if (contact != null)
            {
                _context.ContactForm.Add(contact);
                _context.SaveChanges();
            }
            else if (contact1 != null)
            {
                _context.PatnerwithUs.Add(contact1);
                _context.SaveChanges();
            }
        }

        [HttpPost]
        public string SignUp(string Name, string email, string phone, string country, string company)
        {
            var emailSettings = _configuration.GetSection("EmailSettings").Get<EmailSetting>();
            var EmailSender = emailSettings.EmailSender;
            var EmailReciver = emailSettings.EmailReciver;
            var password = emailSettings.Password;
            try
            {
                MailMessage mailMessage = new MailMessage();
                MailMessage mailMessage1 = new MailMessage();
                mailMessage.From = new MailAddress(EmailSender);
                mailMessage.To.Add(EmailReciver);
                mailMessage1.From = new MailAddress(EmailSender);
                mailMessage1.To.Add(email);

                mailMessage.IsBodyHtml = true;
                mailMessage1.IsBodyHtml = true;
                mailMessage.Subject = "Testing";
                mailMessage1.Subject = "Testing1";
                string body = @"<Html>
                                    <body>
                                        <p> Name : " + Name + "</p> <br> <br>" +
                                        "<p> Email :" + email + "</p> <br> <br>" +
                                        "<p> Phone:" + phone + "</p> <br> <br>" +
                                        "<p> country :" + country + "</p> <br> <br>" +
                                        "<p> company:" + company + "</p> <br> <br> </body></html>";
                mailMessage.Body = body;
                mailMessage1.Body = "Hiii";

                // Smtp Client 

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                NetworkCredential networkCredential = new NetworkCredential(EmailSender, password);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                smtpClient.Send(mailMessage1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            


            return "Thank You , Your mail is submitted";
        }


        [HttpPost]
        public string LeaveReply(string Name, string email, string comment)
        {
            var emailSettings = _configuration.GetSection("EmailSettings").Get<EmailSetting>();
            var EmailSender = emailSettings.EmailSender;
            var EmailReciver = emailSettings.EmailReciver;
            var password = emailSettings.Password;
            try
            {
                MailMessage mailMessage = new MailMessage();
                MailMessage mailMessage1 = new MailMessage();
                mailMessage.From = new MailAddress(EmailSender);
                mailMessage.To.Add(EmailReciver);
                mailMessage1.From = new MailAddress(EmailSender);
                mailMessage1.To.Add(email);

                mailMessage.IsBodyHtml = true;
                mailMessage1.IsBodyHtml = true;
                mailMessage.Subject = "Testing";
                mailMessage1.Subject = "Testing1";
                string body = @"<Html>
                                    <body>
                                        <p> Name : " + Name + "</p> <br> <br>" +
                                        "<p> Email :" + email + "</p> <br> <br>" +
                                        "<p> comment: <br>" + comment + "</p></body></html>";


                mailMessage.Body = body;
                mailMessage1.Body = "Hiii";

                // Smtp Client 

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                NetworkCredential networkCredential = new NetworkCredential(EmailSender, password);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                smtpClient.Send(mailMessage1);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return "Thank You , Your mail is submitted";
        }

        public string createBody()
        {
            return "vgg";
        }

        public string ImageToBase64(string path)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(path);
            string base64Image = Convert.ToBase64String(imageBytes);
            return string.Format("data:image/gif;base64,{0}", base64Image);
        }
        
        [HttpPost]
        public async Task<ActionResult> PatnerContact(string Name, string email, string phone, string country, string Designation, string Company)
        {
            var emailSettings = _configuration.GetSection("EmailSettings").Get<EmailSetting>();
            var EmailSender = emailSettings.EmailSender;
            var EmailReciver = emailSettings.EmailReciver;
            var password = emailSettings.Password;
            try
            {
                MailMessage mailMessage = new MailMessage();
                MailMessage mailMessage1 = new MailMessage();
                mailMessage.From = new MailAddress(EmailSender);
                mailMessage.To.Add(EmailReciver);
                mailMessage1.From = new MailAddress(EmailSender);
                mailMessage1.To.Add(email);

                mailMessage.IsBodyHtml = true;
                mailMessage1.IsBodyHtml = true;
                mailMessage.Subject = "Contacted From Patner";
                mailMessage1.Subject = "Response From Anantya";
                string body = @"<Html>
                                    <body>
                                        <p> Name : " + Name + "</p> <br> <br>" +
                                        "<p> Email :" + email + "</p> <br> <br>" +
                                        "<p> Phone:" + phone + "</p> <br> <br>" +
                                        "<p> Message :" + country + "</p> <br> <br>" +
                                        "<p> Company:" + Company + "</p> <br> <br> <p> Designation:" + Designation + "</p> <br> <br> </body></html>";
                mailMessage.Body = body;
                string htmlBody = System.IO.File.ReadAllText(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/Templates/EmailTemplate.cshtml"));

                // Create LinkedResource for each image and set their Content-IDs
                var logoImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/logo.png"));
                logoImage.ContentId = "logoImage";
                var anotherImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/panel.png"));
                anotherImage.ContentId = "panelImage";
                var aiImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/ai.png"));
                aiImage.ContentId = "aiImage";
                var featureImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/feature.png"));
                featureImage.ContentId = "featureImage";
                var linkdinImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/linkdin.png"));
                linkdinImage.ContentId = "linkdinImage";
                var instagramImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/instagram.png"));
                instagramImage.ContentId = "instagramImage";
                var facebookImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/facebook.png"));
                facebookImage.ContentId = "facebookImage";
                var websiteImage = new LinkedResource(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "./wwwroot/image/website.png"));
                websiteImage.ContentId = "websiteImage";

                // Create the HTML view
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);
                htmlView.LinkedResources.Add(logoImage);
                htmlView.LinkedResources.Add(anotherImage);
                htmlView.LinkedResources.Add(aiImage);
                htmlView.LinkedResources.Add(featureImage);
                htmlView.LinkedResources.Add(linkdinImage);
                htmlView.LinkedResources.Add(instagramImage);
                htmlView.LinkedResources.Add(facebookImage);
                htmlView.LinkedResources.Add(websiteImage);

                // Set the HTML view as the email's body
                mailMessage1.AlternateViews.Add(htmlView);



                // Smtp Client 

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                NetworkCredential networkCredential = new NetworkCredential(EmailSender, password);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                smtpClient.Send(mailMessage1);

                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri("https://api.leadsquared.com/v2/");
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    // Replace with your LeadSquared API access token and API secret key
                    httpClient.DefaultRequestHeaders.Add("accessKey", "u$rce7dad9984ce11949354bb263d4b2ccf");
                    httpClient.DefaultRequestHeaders.Add("secretKey", "b91df9ce97dfe611b5448d0efcf74586439bedf5");

                    string contactData = "[{'Attribute':'FirstName','Value':'Saurabh'},{'Attribute':'EmailAddress','Value':'262Saurabhjhaa@gmail.com'},{'Attribute':'Phone','Value':'9221345631'}]";
                  /*  {

                        FirstName = Name,
                        EmailAddress = email,
                        Phone = phone,
                        Company = Company,

                    };*/
                    // Create a JSON string from your contact form data
                    string jsonContactData = Newtonsoft.Json.JsonConvert.SerializeObject(contactData);

                    // Send a POST request to create a new lead
                    var response = await httpClient.PostAsync("LeadManagement.svc/Capture", new StringContent(contactData, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        // Success handling
                    }
                    else
                    {
                        // Error handling
                    }
                }



                //  var client = new RestClient("https://api.leadsquared.com/v2/LeadManagement.svc/Lead.Create");
                //  RestRequest request = new RestRequest(Method.Post);
                //request.AddHeader("Content-Type", "application/json");
                //request.AddHeader("Authorization", "LSApiKey Your-Access-Key:Your-Secret-Key");

                // Define the data you want to send to LeadSquared
                //   var contactData = new
                // {
                //   FirstName = "John",
                // LastName = "Doe",
                //Email = "johndoe@example.com",
                // Add other fields as needed
                //   };

                //   request.AddJsonBody(contactData);

                // Execute the request
                //  var response = client.Execute(request);

                // Check the response and handle any errors or success accordingly
                //  if (response.IsSuccessful)
                //    {
                // Data was successfully inserted into LeadSquared
                //  }
                //    else
                //  {
                // Handle the error
                //  }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var contact = new PatnerwithUs
            {
                Name = Name,
                Email = email,
                Phone = phone,
                country = country,
                Designation = Designation,
                company = Company,

            };
            SaveData(null, contact);


            return RedirectToAction("PartnerWithUs", "Home");
        }

        public IActionResult SendPDf(string email, int id)
        {
            var emailSettings = _configuration.GetSection("EmailSettings").Get<EmailSetting>();
            var EmailSender = emailSettings.EmailSender;
            var EmailReciver = emailSettings.EmailReciver;
            var password = emailSettings.Password;
            try
            {
                MailMessage mailMessage = new MailMessage();           
                mailMessage.From = new MailAddress(EmailSender);
                mailMessage.To.Add(email);
                mailMessage.IsBodyHtml = true;              
                mailMessage.Subject = "Testing";
                string body = "Thanks For Contact, Please go Through Pdf";
                mailMessage.Body = body;
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                NetworkCredential networkCredential = new NetworkCredential(EmailSender, password);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                switch(id){
                    case 1:
                        // Code to execute for Option 1
                        Attachment attachment = new Attachment("./wwwroot/usecase/Whatsapp_Marketing.pdf");
                        mailMessage.Attachments.Add(attachment);
                        smtpClient.Send(mailMessage);
                        return RedirectToAction("WhatsAppMarketing", "Home"); ;
                        break;
                    case 2:
                        // Code to execute for Option 2
                        Attachment attachment1 = new Attachment("./wwwroot/usecase/Whatsapp_Commerce.pdf");
                        mailMessage.Attachments.Add(attachment1);
                        smtpClient.Send(mailMessage);
                        return RedirectToAction("WhatsAppCommerce", "Home"); ;
                        break;
                    case 3:
                        // Code to execute for Option 3
                        Attachment attachment2 = new Attachment("./wwwroot/usecase/Whatsapp_Support.pdf");
                        mailMessage.Attachments.Add(attachment2);
                        smtpClient.Send(mailMessage);
                        return RedirectToAction("WhatsAppSupport", "Home"); ;
                        break;
                    case 4:
                        // Code to execute for Option 4
                        Attachment attachment3 = new Attachment("./wwwroot/usecase/Whatsapp_Authentication.pdf");
                        mailMessage.Attachments.Add(attachment3);
                        smtpClient.Send(mailMessage);
                        return RedirectToAction("Authentication", "Home"); ;
                        break;
                    default:
                        // Code to execute if option doesn't match any case
                        return RedirectToAction("WhatsAppMarketing", "Home"); ;
                        break;


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("WhatsAppMarketing", "Home"); ;

            }

           
        }
    }
}

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

        public ContactUs1Controller(IWebHostEnvironment hostingEnvironment, AnantyaDbContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;

        }

        

        


        [HttpPost]
        public async Task<string> Contact(string Name, string email, string phone, string message, string url, ContactForm contactForm)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                MailMessage mailMessage1 = new MailMessage();
                mailMessage.From = new MailAddress("mobi.seniordeveloper@gmail.com");
                mailMessage.To.Add("262saurabhjhaa@gmail.com");
                mailMessage1.From = new MailAddress("mobi.seniordeveloper@gmail.com");
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
                                        "<p> Message :" + message + "</p> <br> <br>" +
                                        "<p> url:" + url + "</p> <br> <br> </body></html>";
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

                NetworkCredential networkCredential = new NetworkCredential("mobi.seniordeveloper@gmail.com", "afktcwqzdwfyqjuq");
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
                    httpClient.DefaultRequestHeaders.Add("accessKey", "u$ra7ab62a1fbe3875d15c6907120f9b1b9");
                    httpClient.DefaultRequestHeaders.Add("secretKey", "09408280a20e76f74d1fe1f2a198cf0a306ec434");

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

            };

            SaveData(contact, null);

            return "Thank You , Your mail is submitted";
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
            try
            {
                MailMessage mailMessage = new MailMessage();
                MailMessage mailMessage1 = new MailMessage();
                mailMessage.From = new MailAddress("mobi.seniordeveloper@gmail.com");
                mailMessage.To.Add("262saurabhjhaa@gmail.com");
                mailMessage1.From = new MailAddress("mobi.seniordeveloper@gmail.com");
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

                NetworkCredential networkCredential = new NetworkCredential("mobi.seniordeveloper@gmail.com", "afktcwqzdwfyqjuq");
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
            try
            {
                MailMessage mailMessage = new MailMessage();
                MailMessage mailMessage1 = new MailMessage();
                mailMessage.From = new MailAddress("mobi.seniordeveloper@gmail.com");
                mailMessage.To.Add("262saurabhjhaa@gmail.com");
                mailMessage1.From = new MailAddress("mobi.seniordeveloper@gmail.com");
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

                NetworkCredential networkCredential = new NetworkCredential("mobi.seniordeveloper@gmail.com", "afktcwqzdwfyqjuq");
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
        public async Task<string> Contact1(string Name, string email, string phone, string message, string url)
        {
            return "hi";
        }
        [HttpPost]
        public async Task<ActionResult> PatnerContact(string Name, string email, string phone, string country, string Designation, string Company)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                MailMessage mailMessage1 = new MailMessage();
                mailMessage.From = new MailAddress("mobi.seniordeveloper@gmail.com");
                mailMessage.To.Add("262saurabhjhaa@gmail.com");
                mailMessage1.From = new MailAddress("mobi.seniordeveloper@gmail.com");
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
                                        "<p> Message :" + country + "</p> <br> <br>" +
                                        "<p> url:" + Designation + "</p> <br> <br> <p> Designation:" + Designation + "</p> <br> <br> </body></html>";
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

                NetworkCredential networkCredential = new NetworkCredential("mobi.seniordeveloper@gmail.com", "afktcwqzdwfyqjuq");
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
                    httpClient.DefaultRequestHeaders.Add("accessKey", "u$ra7ab62a1fbe3875d15c6907120f9b1b9");
                    httpClient.DefaultRequestHeaders.Add("secretKey", "09408280a20e76f74d1fe1f2a198cf0a306ec434");

                    var contactData = new
                    {
                        Name = Name,
                        email = email,
                        phone = phone,
                        
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


            return RedirectToAction("Home/PatnerWithUs");
        }
    }
}

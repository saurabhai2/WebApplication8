using Microsoft.AspNetCore.Mvc;
using OpenPop.Pop3;
using OpenPop.Mime;
using System;
using System.Collections.Generic;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class EmailController : Controller
    {
        public ActionResult Inbox()
        {
            string host = "pop.gmail.com";
            int port = 995; // IMAPS
            string username = "mobi.seniordeveloper@gmail.com";
            string password = "afktcwqzdwfyqjuq";

            List<Email> emails = new List<Email>();

            using (var client = new Pop3Client())
            {
                client.Connect(host, port, true);
                client.Authenticate(username, password);

                int messageCount = client.GetMessageCount();
                for (int i = messageCount; i > 0; i--)
                {
                    var message = client.GetMessage(i);
                    emails.Add(new Email
                    {
                        From = message.Headers.From.DisplayName,
                        Subject = message.Headers.Subject,
                        Body = message.FindFirstPlainTextVersion().GetBodyAsText(),
                        Date = message.Headers.DateSent
                    });
                }

                client.Disconnect();
            }

            return View(emails);
        }
    }
}

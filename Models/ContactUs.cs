namespace WebApplication8.Models
{
    public class ContactUs
    {

        public string Name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
       
        public string message { get; set; }
        public string url { get; set; }
    }

    public class EmailSetting
    { 
        public string EmailSender { get; set; }
        public string EmailReciver { get; set; }
        public string Password { get; set; }



    }

    
}

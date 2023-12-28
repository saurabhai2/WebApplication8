using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    public class ContactForm
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }

        public string url { get; set; }

        public string RefNumber { get; set; }

    }

    public class PatnerwithUs 
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Designation { get; set; }

        public string country { get; set; }
        public string company { get; set; }



    }
}

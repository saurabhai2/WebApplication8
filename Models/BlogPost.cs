using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }

        
        public string Title { get; set; }

        public string Category { get; set; }

        
        public string Meta { get; set; }

        
        public string Schema { get; set; }

        public string datePublish { get; set; }

        
        public string author { get; set; }
       
        public string MainHeading { get; set; }
        
        public IFormFile FeatureImage { get; set; }
        public string FeatureImagePath { get; set; }

        
        public string Content { get; set; }
        public string SlugUrl { get; set; }
    }

    public class KnowlageCentre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string CetegoryLine { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Meta { get; set; }

        [Required]
        public string Schema { get; set; }

        public string datePublish { get; set; }

        [Required]
        public string author { get; set; }
        [Required]
        public string MainHeading { get; set; }

        [Required]
        public string Content { get; set; }
        public string SlugUrl { get; set; }
    }
}
